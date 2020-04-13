# OpenVR XR SDK Package

The purpose of this package is to provide OpenVR XR SDK Support. This package provides the necessary sdk libraries for users to build Applications that work with the OpenVR runtime. The OpenVR XR Plugin gives you access to all major VR devices through one interface. Explicit support for: HTC Vive, HTC Vive Cosmos, HTC Vive Tracker, Oculus Touch, Windows Mixed Reality, Logitech VR Ink, and Valve Index. Other SteamVR compatible devices are supported though may have inaccurate or incomplete features.

# Documentation

There is some brief documentation included with this plugin at /Documentation~/com.valve.openvr.md

## QuickStart

### SteamVR Legacy Input (default mode):
* Go to the package manager window (Window Menu -> Package Manager)
* Add the OpenVR XR API package
* Hit the + button in the upper left hand corner
* Select “Add package from git URL”
* Paste in: https://github.com/zite/TestPackage.git#TestBranch (temporary url)
* Open the XR Management UI (Edit Menu -> Project Settings -> XR Plugin Management)
* Under Plugin Providers hit the + icon and add “Open VR Loader”
* Add a couple cubes to the scene (scale to 0.1)
* Add TrackedPoseDriver to both cubes and the Main Camera
  *	Main Camera: Under Tracked Pose Driver:
* For Device select: “Generic XR Device”
* For Pose Source select: “Center Eye - HMD Reference”
* Cube 1:
  *	For Device select: “Generic XR Controller”
  *	For Pose Source select “Left Controller”
* Cube 2:
  *	For Device select: “Generic XR Controller”
  *	For Pose Source select “Right Controller” 
* Hit play and you should see a tracked camera and two tracked cubes


### SteamVR Legacy Input with Unity Input System:
* Go to the package manager window (Window Menu -> Package Manager)
* Add the OpenVR XR API package
* Hit the + button in the upper left hand corner
* Select “Add package from git URL”
* Paste in: https://github.com/zite/TestPackage.git#TestBranch (temporary url)
* Open the XR Management UI (Edit Menu -> Project Settings -> XR Plugin Management)
* Under Plugin Providers hit the + icon and add “Open VR Loader”
* Add the Unity Input System package
* Go to the package manager window (Window Menu -> Package Manager)
* Look for the Input System package
* Click Install
* Open Input System debug window (Window -> Analysis -> Input System Debugger)
* Verify devices load as expected and are getting reasonable values. All controllers should have the correct buttons and touch states (including index)


### SteamVR Input System:
* Install SteamVR Unity Plugin v2.6b (https://drive.google.com/file/d/1xJSaIa8ymHxG4D9CdqMyVXtRQWSR7UAc/view?usp=sharing) (temporary url)
* It should install the OpenVR XR API package automatically for 2020.1+ for 2019.3 you’ll need to add it with the instructions above.
* Open the SteamVR Input window (Window -> SteamVR Input)
* Accept the default json
* Click Save and Generate
* Open the Interactions_Example scene (Assets/SteamVR/InteractionSystem/Samples/Interaction_Example.unity)
* Hit play, verify that you can see your hands and teleport around (no errors)
