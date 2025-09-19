# Unity Vehicle Controller Prototype

## Overview
This project is a Unity prototype featuring a simple vehicle controller. The player can control a vehicle's movement and rotation using keyboard input. The core logic is implemented in the `PlayerController.cs` script.

## Features
- Move the vehicle forward and backward
- Turn the vehicle left and right
- Adjustable speed and turn rate

## Getting Started
1. **Clone or download the repository.**
2. **Open the project in Unity (v6 recommended).**
3. **Open the main scene in `Assets/Scenes/`.**
4. **Press Play to test the vehicle controls.**

## Controls
- **W / S or Up / Down Arrow:** Move forward/backward
- **A / D or Left / Right Arrow:** Turn left/right

## File Structure
- `Assets/Scripts/PlayerController.cs`: Main vehicle controller script
- `Assets/Scenes/`: Contains Unity scenes

## Customization
You can adjust the vehicle's speed and turn rate by modifying the constants in `PlayerController.cs`:
```csharp
private const float VehicleSpeed = 20;
private const float VehicleTurnSpeed = 25;
```

## License
This project is for educational and prototyping purposes.

