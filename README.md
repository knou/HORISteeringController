# HORI Steering Controller for Unity 5  
![screenshot](https://github.com/knou/HORISteeringController/blob/master/medias/horisteeringController.jpg)  
<http://www.hori.jp/products/ps4/ps4_steeringwheel/>

## Setup
```
menu/SteeringController/EnableInput
```
![screenshot](https://github.com/knou/HORISteeringController/blob/master/medias/horisteeringController.gif)  

## Usage
```c#
// Handle Input
var handleValue = Input.GetAxis ("HANDLE");

// Button Input
// "SQUARE", "CROSS", "CIRCLE", "TRIANGLE",  "L1", "R1", 
// "LLEVER", "RLEVER", "SHARE", "OPTIONS", "L3", "R3", "PS"
if (Input.GetButtonDown("SQUARE")) {
	//hoge
}
```
