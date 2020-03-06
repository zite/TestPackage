using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using System.IO;

namespace Unity.XR.OpenVR.Editor
{
    public class SettingsCopier
    {
        [PostProcessBuildAttribute(1)]
        public static void OnPostprocessBuild(BuildTarget target, string pathToBuiltProject)
        {
            FileInfo buildPath = new FileInfo(pathToBuiltProject);
            string buildName = buildPath.Name.Replace(buildPath.Extension, "");
            DirectoryInfo buildDirectory = buildPath.Directory;

            string dataDirectory = Path.Combine(buildDirectory.FullName, buildName + "_Data");
            if (Directory.Exists(dataDirectory) == false)
            {
                string vsDebugDataDirectory = Path.Combine(buildDirectory.FullName, "build/bin/" + buildName + "_Data");
                if (Directory.Exists(vsDebugDataDirectory) == false)
                {
                    Debug.LogError("<b>[OpenVR]</b> Could not find (vs debug) data directory at: " + dataDirectory);
                    Debug.LogError("<b>[OpenVR]</b> Could not find data directory at: " + dataDirectory);
                }
                else
                    dataDirectory = vsDebugDataDirectory;
            }

            string streamingAssets = Path.Combine(dataDirectory, "StreamingAssets");
            if (Directory.Exists(streamingAssets) == false)
                Directory.CreateDirectory(streamingAssets);

            string streamingSteamVR = Path.Combine(streamingAssets, "SteamVR");
            if (Directory.Exists(streamingSteamVR) == false)
                Directory.CreateDirectory(streamingSteamVR);


            OpenVRSettings settings = OpenVRSettings.GetSettings();
            FileInfo currentSettingsPath = new FileInfo(AssetDatabase.GetAssetPath(settings));
            FileInfo newSettingsPath = new FileInfo(Path.Combine(streamingSteamVR, "OpenVRSettings.asset"));

            if (newSettingsPath.Exists)
            {
                newSettingsPath.IsReadOnly = false;
                newSettingsPath.Delete();
            }

            File.Copy(currentSettingsPath.FullName, newSettingsPath.FullName);

            Debug.Log("Copied openvr settings to build directory: " + newSettingsPath.FullName);
        }
    }
}