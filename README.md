## VIVE Unity uGUI SDK
This package is modified from [Oculus Unity SDK](https://developer.oculus.com/downloads/
). 
Use the right controller of HTC VIVE as mouse to interact with uGUI.

## Requirement
Unity version : Unity 2018.2.18f1
SteamVR version : SteamVR 2.2

## Getting Started
- Create a basic VIVE environment.

![](https://i.imgur.com/voL7igx.png)

- Add TrackpadTouchAxis in SteamVR Input window and bind on trackpad position. ([Tutorial](https://www.youtube.com/watch?v=bn8eMxBcI70&list=PLmc6GPFDyfw83KiqUHZceuThGKoyO4hkt))

![](https://i.imgur.com/MHptIQ7.png)
![](https://i.imgur.com/t67AmKs.png)
- Import VIVE_VR.unitypackage. (download from release page)
- Drag the [VIVE Pointer] prefab to Controller (right).

![](https://i.imgur.com/A2ux14b.png)
- Create a Canvas and change the render mode to World Space.
- Set scale to (0.01, 0.01, 0.01) and position to (0, 0, 3).
- Assign the Camera (under the [CameraRig]) to Event Camera.
- Remove Graphic Raycaster component and add OVRRaycaster component.
- Assign Pointer to OVRRaycaster(Pointer)

![](https://i.imgur.com/t1T5jBh.png)
- Copy EventSystem and renamed to VREventSystem.
- Remove Standalone Input Module on VREventSystem and add OVRInputModule component.
- Assign Pointer to OVRInputModule (RightController & RayAnchor)

![](https://i.imgur.com/TF82yBs.png)