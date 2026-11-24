# Charizard AR

An iOS augmented reality game built in Unity. Point the camera at the reference image and a 3D Charizard spawns on it. An on-screen joystick moves it around the real world, switching between its idle and flying animations.

## How it works
- **Image tracking:** `ARTrackedImageSpawner` listens to AR Foundation's `ARTrackedImageManager` and spawns the Charizard prefab on each newly detected reference image.
- **Movement:** `CharizardController` reads a fixed on-screen joystick, drives the Rigidbody's velocity, turns the model to face the direction of travel, and toggles the `flyParam` animator flag while moving.

## Tech
Unity 6 (6000.6.2f1) · C# · AR Foundation 6.6 · ARKit · Input System · iOS

## Run it
1. Open the folder in Unity Hub with Unity **6000.6.2f1** (Unity regenerates `Library/` on first open).
2. Open `Assets/Scenes/SampleScene.unity`.
3. **File → Build Settings → iOS → Build**, then open the generated Xcode project, set your signing team, and run on an ARKit-capable iPhone.
4. Point the camera at the reference image to spawn Charizard, then use the joystick to fly it around.

## Credits
- 3D model: "[Charizard 006 Legends ZA](https://sketchfab.com/3d-models/charizard-006-legends-za-661ea62da9b5405fb5b01407dd88bc47)" by [jimmyho905](https://sketchfab.com/jimmyho905), licensed under [CC BY 4.0](http://creativecommons.org/licenses/by/4.0/).
- Joystick: [Joystick Pack](https://assetstore.unity.com/packages/tools/input-management/joystick-pack-107631) by Fenerax Studios.
- Charizard and Pokémon are trademarks of Nintendo, Game Freak and Creatures. This is a non-commercial fan project for learning AR development.
