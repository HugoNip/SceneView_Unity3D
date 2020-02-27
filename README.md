# Navigation Controls in VR by Controllers

## Introduction
This project shows a simple example of using controllers for navigation and UI in a virtual environment.

## What can users do in this virtual environment?
1. Navigation (forward, backward, up, down, rotation)
2. Interaction with 3D UI (bottons, toggles, scrollbars)

[**Demo**](https://youtu.be/F4rgRLcNyo0)

![screenshot-www.youtube.com-2020.02.27-09_59_53.png](https://github.com/HugoNip/SceneView_Unity3D/blob/master/figure/screenshot-www.youtube.com-2020.02.27-09_59_53.png)

![screenshot-www.youtube.com-2020.02.27-10_00_59.png](https://github.com/HugoNip/SceneView_Unity3D/blob/master/figure/screenshot-www.youtube.com-2020.02.27-10_00_59.png)

## Hardwares
PC: Intel Core i9-8950HK CPU @ 2.90GHz 2.90GHz/32G RAM/GeForce GTX 1080  
Windows 10 x64  
[Unity3D 2019.3.2.f1](https://unity3d.com/get-unity/download/archive?_ga=2.40182242.1304774695.1582602743-918063752.1582602743)  
[HTC VIVE](https://www.vive.com/us/product/vive/)  

## Plugin
After opening the Unity3D, go to the **Asset Store** to download and import the **SteamVR Plugin**.

## How to Run Unity project
Download and run it directly. **Test06RayCastFinished.unity** shows thye finished scene.

## Main Assets
Teleportation, including Teleporting, TeleportAreaVisible, TeleportArea(C# Script).


## Introduction of Controllers
![Introduction.jpg](https://github.com/HugoNip/SceneView_Unity3D/blob/master/figure/Introduction.jpg)

[**Official Documents of Controllers**](https://www.vive.com/eu/support/vive/category_howto/about-the-controllers.html)

|**Button Name** |       **Left Controller**                        |        **Right Controller**        |  
|----------------|--------------------------------------------------|------------------------------------|  
|Menu Button     |Click to show raycast                             |Click to hide raycast               |  
|TrackPad        |Touch to go forward or backward                   |Touch to go up or down              |  
|Trigger         |Pull to select the detination and Click to arrive |Click buttons, checkboxs and toggles|  
|Grip Button     |Click to show UI pannel                           |Click to hide UI pannel             |  

