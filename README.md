# Navigation and Interaction with 3D UI in VR

## Introduction
This project shows a simple example of using controllers for navigation and interaction with 3D UI in a virtual environment.

## What Can Users Do in This Virtual Environment?
### 1. Navigation
go forward, backward, up, down, rotation
### 2. Interaction with 3D UI
click bottons, check toggles, slide scrollbars

[**Demo**](https://youtu.be/F4rgRLcNyo0)

![screenshot-www.youtube.com-2020.02.27-09_59_53.png](https://github.com/HugoNip/SceneView_Unity3D/blob/master/figure/screenshot-www.youtube.com-2020.02.27-09_59_53.png)

![screenshot-www.youtube.com-2020.02.27-10_00_59.png](https://github.com/HugoNip/SceneView_Unity3D/blob/master/figure/screenshot-www.youtube.com-2020.02.27-10_00_59.png)

## How to make this project work in your PC
### 1. Hardwares
PC: Intel Core i9-8950HK CPU @ 2.90GHz 2.90GHz/32G RAM/GeForce GTX 1080  
Windows 10 x64  
[Unity3D 2019.3.2.f1](https://unity3d.com/get-unity/download/archive?_ga=2.40182242.1304774695.1582602743-918063752.1582602743)  
[HTC VIVE](https://www.vive.com/us/product/vive/)  

### 2. Plugin
After opening the Unity3D, go to the **Asset Store** to download and import the **SteamVR Plugin**.

### 3. Main Assets
Teleportation, including Teleporting, TeleportAreaVisible, TeleportArea(C# Script).

### 4. Scenes 
Download and run it directly. **Test06RayCastFinished.unity** shows the finished scene.

### 5. Introduction of Controller Operations

|**Button Name** |       **Left Controller**                        |        **Right Controller**        |  
|----------------|--------------------------------------------------|------------------------------------|  
|Menu Button     |Click to show raycast                             |Click to hide raycast               |  
|TrackPad        |Touch to go forward or backward                   |Touch to go up or down              |  
|Trigger         |Pull to select the detination and Click to arrive |Click buttons, checkboxs and toggles|  
|Grip Button     |Click to show UI pannel                           |Click to hide UI pannel             |  

![Introduction.jpg](https://github.com/HugoNip/SceneView_Unity3D/blob/master/figure/Introduction.jpg)

### 6. Related Toturials
[**Official Documents of Controllers**](https://www.vive.com/eu/support/vive/category_howto/about-the-controllers.html)  
**Video** [**01**](https://www.youtube.com/watch?v=iJ0oNYIUFJo&list=PLIzNKynZC57jGBlbrs1-rLyYqCZI0crsO&index=3&t=0s)  
**Video** [**02**](https://www.youtube.com/watch?v=5C6zr4Q5AlA&list=PLIzNKynZC57jGBlbrs1-rLyYqCZI0crsO&index=5&t=734s)  
**Video** [**03**](https://www.youtube.com/watch?v=bn8eMxBcI70&list=PLIzNKynZC57jGBlbrs1-rLyYqCZI0crsO&index=6&t=0s)  
**Video** [**04**](https://www.youtube.com/watch?v=N_R5V6KNFhA&list=PLIzNKynZC57jGBlbrs1-rLyYqCZI0crsO&index=10&t=0s)  
**Video Series** [**05**](https://www.youtube.com/watch?v=TUSvupeYZv4&list=PLIzNKynZC57jGBlbrs1-rLyYqCZI0crsO&index=10), [**06**](https://www.youtube.com/watch?v=ZI6DwJtjlBA&list=PLIzNKynZC57jGBlbrs1-rLyYqCZI0crsO&index=12&t=0s)  
**Video Series** [**07**](https://www.youtube.com/watch?v=3mRI1hu9Y3w&list=PLIzNKynZC57jGBlbrs1-rLyYqCZI0crsO&index=14&t=19s), [**08**](https://www.youtube.com/watch?v=h_BMXDWv10I), 
[**09**](https://www.youtube.com/watch?v=vNqHRD4sqPc)

## Issues and Solutions
1. Because of the device limitation, especially the GPU, the controllers always drift in the virtual environment.
2. Try to reinstall SteamVR or recalibrate the controllers and HMD to fix the issues when you suffer from any issues about SteanVR and controllers.
3. I cannot reachieve the motion of [**Video 02**](https://www.youtube.com/watch?v=5C6zr4Q5AlA&list=PLIzNKynZC57jGBlbrs1-rLyYqCZI0crsO&index=5&t=734s) from 17:30s to 19:04s, I found that there was a problem with the function of "**charactorController.Move()**", I cannot achieve teleportation and movement simultaneously. I thought it maybe the problem with devices, I use [**HTC Vive controllers**](https://www.vive.com/us/accessory/controller/), and the author used [**HTC VIVE Pro Controllers**](https://www.vive.com/us/accessory/cosmos-controller-left/), but I am not sure whether this is the right factor or not.  
![screenshot-www.youtube.com-2020.02.27-12_11_37.png](https://github.com/HugoNip/SceneView_Unity3D/blob/master/figure/screenshot-www.youtube.com-2020.02.27-12_11_37.png)
