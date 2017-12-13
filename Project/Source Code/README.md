# Shoot the Object - HoloLens (User Manual)

## Setting-up and Using the HoloLens Application 

### Senario 1: You have a HoloLens device
- Prerequisites
  - A Windows 10 PC with the _[necessary development tools](https://developer.microsoft.com/en-us/windows/mixed-reality/install_the_tools)_
- Project Files & Requirements
  - Download the _[files](https://github.com/kcshettar/cg2f2017/tree/master/Project/Source%20Code)_ required by the project. Extract the files to an easy to remember location
  - This project requires the most recent version of Unity with Mixed Reality support
  - _[Project Report](https://github.com/kcshettar/cg2f2017/tree/master/Project/Report)_
- Running The Application Using Visual Studio and HoloLens Device
  - Connect the HoloLens device to Host machine 
  - Open the downloaded file **HoloLens Unity Project**
  - Navigate to **HoloLens Unity Project\App\HoloLens Unity Project.sln** and open the solution using Visual Studio IDE
  - Change the architecture from **ARM** or **x64** to **x86** in Visual Studio IDE
  - Choose the hosting platform as **Remote Machine** to deploy the application
  - Click on **Debug** and choose **Start Without Debugging** 
  - Now you can see the Application running on the HoloLens device 
- Using the application
  - **Requirements:** User should know basic *tap* gestures of HoloLens device
  - Use **Gaze: Head Movement** to navigate and select the object
  - Use **tap** *(Presssed)* gesture to shoot the ball. The blocks will move on collision
  - Use the voice command **Reset Blocks** to reset the cubes in Application

### Scenario 2: You do not have a HoloLens device
- Prerequisites
  - A Windows 10 PC with the _[necessary development tools](https://developer.microsoft.com/en-us/windows/mixed-reality/install_the_tools)_ and _[configured to support a Windows Mixed Reality immersive headset.](https://developer.microsoft.com/en-us/windows/mixed-reality/immersive_headset_setup)
- Project Files & Requirements
  - Download the _[files](https://github.com/kcshettar/cg2f2017/tree/master/Project/Source%20Code)_ required by the project. Extract the files to an easy to remember location
  - This project requires the most recent version of Unity with Mixed Reality support
  - _[Project Report](https://github.com/kcshettar/cg2f2017/tree/master/Project/Report)_
- Running The Application Using Visual Studio and HoloLens Emulator
  - Open the downloaded file **HoloLens Unity Project**
  - Navigate to **HoloLens Unity Project\App\HoloLens Unity Project.sln** and open the solution using Visual Studio IDE
  - Change the architecture from **ARM** or **x64** to **x86** in Visual Studio IDE
  - Choose the hosting platform as **HoloLens Emulator v.xxxx** to deploy the application
  - Click on **Debug** and choose **Start Without Debugging** 
  - Now you can see the Application running on the HoloLens Emulator
- Using the application
  - Use the keys **W, A, S, D** and **Arrow Keys** to navigate and select the object
  - Hit **Enter** or use **Left Mouse Click** to shoot the ball. The blocks will move on collision
  - Use the voice command **Reset Blocks** to reset the cubes in Application

## Demo
_[Navigate to YouTube]()_

## References
_[Official: Mixed-Reality Development Website](https://developer.microsoft.com/en-us/windows/mixed-reality/development)_

> Author : [Kiran Shettar](https://www.cs.uml.edu/~kshettar)