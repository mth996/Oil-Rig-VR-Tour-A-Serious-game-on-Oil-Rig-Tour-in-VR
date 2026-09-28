# Oil Rig VR Tour

An educational **virtual reality serious game** built in Unity for **Meta/Oculus Quest 2**, designed to introduce users to an oil-rig environment, key drilling components, and location-based learning objectives through an immersive guided experience.

> **Portfolio Project:** VR Education / Serious Game / Industrial Simulation

## Overview

Oil Rig VR Tour combines immersive exploration with guided learning and knowledge assessment. The experience introduces the player to important oil-rig and drilling components through an AI-guided tour, then reinforces that learning through a second level where the player must identify key locations and complete the required objectives.

The project evolved through multiple development iterations, including migration to Unity's XR Origin workflow, implementation of NavMesh-based guidance, interactive UI systems, environmental movement systems, NPC animation, objective tracking, and performance optimization for standalone VR hardware.

## Experience Flow

### 1. Guided Oil-Rig Tour
The player explores the environment while a NavMesh-controlled guide moves between important drilling components. Contextual UI panels provide information as the tour reaches each location.

Components represented in the guided learning flow include:

- Blowout Preventer
- Shale Shakers
- Mud Pump
- Derrick
- Drill Collar
- Drill String
- Drawworks
- Iron Roughnecks
- Top Drive
- Turntable

### 2. Location-Based Knowledge Assessment
A second offshore level tests what the player learned during the guided tour. The player must locate key oil-rig components and complete the associated objectives.

The objective system tracks locations including the **Turntable, Drawworks, Blowout Preventer, Shale Shakers, and Mud Pump**. Level completion is triggered only after the required locations have been visited and the quiz has been completed.

## Core Systems

### NavMesh-Guided Learning
`DrillComponents.cs` coordinates the guided tour using Unity's `NavMeshAgent`. The guide moves between predefined destinations while trigger events and UI panels present information about individual drilling components.

### Objective & Progress Tracking
`GameManager.cs` tracks the player's progress across the assessment level. Individual destination scripts report completed objectives, and the level-complete state is activated after all required locations and the quiz are completed.

### Location Interaction
Dedicated destination scripts handle individual oil-rig objectives, including:

- `BOPDestination.cs`
- `DrawWorksDestination.cs`
- `MudPumpDestination.cs`
- `ShaleShakersDestination.cs`
- `TurnTableDestination.cs`

These systems connect world-space exploration with objective state and UI feedback.

### Elevator & Environment Systems
The project includes elevator/lift mechanics to support movement through the industrial environment and create a more dynamic VR tour.

### UI & Scene Flow
UI systems communicate objectives, component information, completion states, and navigation between the main menu and playable levels.

## Technical Highlights

- Standalone VR development for **Oculus / Meta Quest 2**
- Unity XR Origin-based VR setup
- **NavMeshAgent** guided NPC/tour system
- Trigger-based contextual learning interactions
- Multi-stage objective tracking
- Quiz-linked level completion logic
- Elevator and environmental movement systems
- Animated NPC characters
- UI feedback for completed objectives
- Performance optimization for standalone VR

## Optimization for Quest 2

Performance was an important part of the final development stage. Earlier versions included additional vehicle models and heavier scene content, but these were reduced after testing showed that the scene was too demanding for the Quest 2 target hardware.

The final version prioritized a smoother standalone VR experience, including use of the **Universal Render Pipeline (URP)** and reduction of unnecessary scene complexity.

## Selected C# Systems

| Script | Purpose |
| --- | --- |
| `DrillComponents.cs` | Controls the NavMesh-guided tour, component UI, destinations, and tour progression |
| `GameManager.cs` | Tracks assessment objectives, quiz completion, and level completion |
| `UIManager.cs` | Updates objective and interface feedback |
| `TriggerToOnNavmesh.cs` | Reactivates navigation based on player trigger events |
| `ElevatorSystem.cs` | Controls lift/elevator movement |
| Destination scripts | Validate discovery of individual oil-rig components |

## Development Evolution

The project was developed iteratively:

**Version 1** established the initial Quest 2 VR interaction and adapted the project to Unity's updated XR Origin workflow.

**Version 2** expanded the experience with elevator mechanics, NavMesh navigation, a second offshore assessment level, and URP-based rendering improvements.

**Version 3** completed the guided component tour, location-based assessment, objective/win conditions, animated NPCs, and Quest-focused optimization.

## My Role

I developed the Unity implementation of the VR experience, including the guided tour logic, NavMesh navigation, drilling-component interactions, UI progression, objective tracking, elevator mechanics, scene flow, NPC integration, and Quest 2 optimization.

This project demonstrates my early work in **VR serious games and industrial/educational XR**, particularly the use of immersive environments to combine guided instruction with interactive assessment.

## Media

- [Trailer / Project Media](https://drive.google.com/drive/folders/1-5fgRt90JthuPtU9JToPwdHaIrzr5lgl)
- [Walk-Through Presentation](https://drive.google.com/file/d/1VK0wHLCJBsIvj4WdIH09yO-O2yRb1nt-/view?usp=share_link)

## Future Portfolio Update

Project screenshots and selected gameplay images can be added here to visually document the guided tour, drilling components, offshore assessment level, and Quest 2 experience.
