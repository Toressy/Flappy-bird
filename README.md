# 🕹️ FlappyUnity-Platformer

A 2D Unity platformer game project inspired by the classic Flappy Bird, built with additional gameplay elements such as animated mushrooms, sticky platforms, and environmental hazards. Developed in C# using Unity’s built-in physics engine and game loop.

## 🎮 Features

- Smooth side-scrolling camera system
- Prefab-based environment objects (walls, land, blocks)
- Interactable elements like mushrooms and sticky platforms
- Collision-based score/health system
- Modular and reusable C# scripts

## 🧱 Project Structure

── Assets/
  ── Scripts/ # Game logic scripts (C#)
  ── Sprites/ # Visual assets
  ── Scenes/ # Unity scenes
  ── Land/, Title/, etc. # Prefabs and game objects
── Packages/ # Unity packages
── ProjectSettings/ # Unity project settings


## 🧩 Main Scripts

- `CameraScript.cs` – Camera follow behavior
- `DestroyScript.cs` – Handles collision and object cleanup
- `PlatformMovementScript.cs` – Movement logic for platforms
- `SmileScript.cs`, `MushroomScript.cs` – Visual feedback and interactions
- `WallScript.cs` – Wall spawn/move/destroy behavior

## 🚀 Getting Started

1. Clone the repository
2. Open the folder in Unity Hub
3. Open the main scene inside `Assets/Scenes/`
4. Press ▶️ to run the game in the Unity editor

## 🔧 Requirements

- Unity 2020.3 or later
- No external packages required
