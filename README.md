# Fov Previewer

**Fov Previewer** is an application that allows you to observe and experiment with various FOV dimensions.

## Preview

- **[Video Preview](https://www.bilibili.com/video/BV1x24y137gg/?share_source=copy_web&vd_source=fda0881cecec7be0b06545af6b91d097)**

![Untitled](Images/Untitled.png)

![Untitled](Images/Untitled%201.png)

## Requirements

- Meta Quest 2 / Pro
- Enable developer mode (you can follow [these instructions](https://developer.oculus.com/documentation/native/android/mobile-device-setup/)).

## How to install?

[Download APK Default](https://github.com/Eis4TY/Fov-Previewer/releases/download/0.1/FovPreviewer.apk).
[Download APK Passthrough](https://github.com/Eis4TY/Fov-Previewer/releases/download/0.1/FovPreviewer_PassThrough.apk).
- Connect Quest to computer, use SideQuest or other ADB tools to install it.

## How to build?

1. Clone this project.
2. Open the project with Unity 2021.3 (Android Build).
3. Under **Project Settings**, navigate to **MRTK3**. For the profile, search and select **MRTKProfile** both fo**r Windows** and **Android** tab

![Untitled](Images/Untitled%202.png)

### Enable Passthrough (optional)

1. On the **Hierarchy** tab, select **MRTK XR Rig**.
2. On the **Inspector** tab, from the bottom, click **Add Component**, and then from the list, select **OVRManager** and **OVRPassthroughLayer** script.
3. Refer to ****[Oculus developers](https://developer.oculus.com/documentation/unity/unity-passthrough/)**** for subsequent steps and other Settings.

![Untitled](Images/Untitled%203.png)
