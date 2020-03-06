using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Unity.XR.OpenVR
{
    public class OpenVRHelpers
    {
        public static bool IsUsingSteamVRInput()
        {
            return DoesTypeExist("SteamVR_ActionSet");
        }

        public static bool DoesTypeExist(string className, bool fullname = false)
        {
            Type foundType = null;
            if (fullname)
            {
                foundType = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                             from type in assembly.GetTypes()
                             where type.FullName == className
                             select type).FirstOrDefault();
            }
            else
            {
                foundType = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                             from type in assembly.GetTypes()
                             where type.Name == className
                             select type).FirstOrDefault();
            }

            return foundType != null;
        }
    }
}