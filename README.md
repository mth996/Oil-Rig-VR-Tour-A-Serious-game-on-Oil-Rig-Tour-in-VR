# Oil-Rig-VR-Tour-A-Serious-game-on-Oil-Rig-Tour-in-VR
The project has 3 version of development which will be explained below.
1 Details of Release Plan

1.1 Version 1 of Oil rig VR
The developer did all the technical research on various online sites and got more than one plugin to make the VR game that will work on the Quest 2 . Due to the frequent updates in Unity, many plugins got major updates. These changed some of the plugins that were used in the Version like XR Tool Kit in Unity for VR games. The first version was just button click in VR which was a success in building the first version. The version worked flawlessly in VR. But due to the XR plugin changed  to XR origin the developer had issues  resolving some plugin bugs. Finally the developer managed to resolve the bugs an was able implement the XR origin 

1.2 Version 2 of Oil rig VR
In the Version 2 elevator system was implemented to have dynamic environments I the game, the developer downloaded car models and implemented them in the game which worked properly. The developer then implemented AI Navmesh which is unity’s build in pathfinding AI. The developer also started building the second level  which was on water and had to implement a testing method to test players knowledge based on level one the implementation of the two levels were working but not optimized. In order to the do this the developer implemented Universal Render Pipeline (URP).

1.3 Version 3 of Oil rig VR
In the Version 3 the game Oil rig vr is almost complete and the implementation of AI Navmesh where the robot goes to different components and explains about each of them and in the second level five locations are to be located by the player as a test in the game. The first thing in the game is from start menu which is the garage the player can load in to both levels and complete the objectives of each level to meet the winning condition of the game. The game was finally completed by implementing NPC characters with animation to enhance the gameplay experience . but he developer had to remove the cars from the first level because it was becoming too heavy for oculus quest to render do many models and textures at the same time. Thus in the final buid there is no cars and the runs smoothly on oculus quest 2 as well.

Code explanation

Lines	DrillComponents.cs
89-94	Defines the navemesh agent location on awake method
98-105	Defines the function which activates the start panel the nav mesh destination is set to a new location
106-141	Defines if else statement to activate different panels on Lara when it visits certain location and triggers a collider
143-150	Defines ienumerator which is currently not used because the developer found a beter way to activate the navmesh which is turned off in line 122
153-302	 Defines different functions which does almost the same thing but for different components that is to activate or de activate UI panels of different drilling components and also setting the NavMnesh location in every function to let lara identify the location of each components displayed on the screen. 
306- 426	Defines different OnbuttonClicks which does almost the same thing but for different components that is to access the function stated from line 153 to 302 when the button is clicked.

Line 	TriggerToOnNavmesh.cs
7- 16	Defines a on trigger function which is triggered when a collider with tag player comes into contact with the trigger which activates the navmesh which was deactivated in DrillComponents.cs line122 and at line 129 of DrillComponents.cs new navmesh destination is set which is derrick.


Line 	DrawWorkDestination.cs
8-16	This script destroys the  game object it is attached to and sets a Boolean to true which an instance of the game manager. The code calls function from the UI manager  which changes the text displayed in the canvas from “Locate Draw Works” to “Draw works Located” and changes color from white to green

Line 	BOPDestination.cs
8-16	        This script destroys the  game object it is attached to and sets a Boolean to true which an instance of the game manager. The code calls function from the UI manager which changes the text displayed in the canvas from “Locate Blow Out Preventer ” to “Blow Out Preventer Located” and changes color from white to green
 
Line 	TurnTableDestination.cs
8-16	        This script destroys the game object it is attached to and sets a Boolean to true which an instance of the game manager. The code calls function from the UI manager which changes the text displayed in the canvas from “Locate Turn Table” to “Turn Table Located” and changes color from white to green



Line 	ShaleShakersDestination.cs
8-16  	This script destroys the  game object it is attached to and sets a Boolean to true which an instance of the game manager. The code calls function from the UI manager which changes the text displayed in the canvas from “Locate Shale Shakers” to “Shale Shakers Located” and changes color from white to green
 
Line 	MudPumpDestination.cs
8-16 	This script destroys the  game object it is attached to and sets a Boolean to true which an instance of the game manager. The code calls function from the UI manager which changes the text displayed in the canvas from “Locate Mud Pump” to “Mud Pump Located” and changes color from white to green

  
 
Lines	GameManager.cs
35- 42	Defines functions checks for if the Booleans are true then a function to end the game is called. As this script is singleton thus other codes such as DrawWorksDestination.cs, BOPDestination.cs, TurnTableDestination.cs,  MudPumpDestination.cs, ShaleShakerDestination.cs    access these functions  when they are triggered they turn the Booleans to true.
 
Lines 	UIManager.cs
42-74	Defines functions which changes the color and the text. As this script is singleton thus other codes such as
DrawWorksDestination.cs, BOPDestination.cs, TurnTableDestination.cs,  MudPumpDestination.cs, ShaleShakerDestination.cs    access these functions  when they are triggered.
  

Lines	ElevatorSystem.cs
15-41	 This script checks if the vector 3 of this game object and considers it as ground and uses the vector to move the lift from ground to end destination.
  
  
Lines	Lift script.cs
15-41	 This script uses the game object it is attached to call a function when the trigger is collided by a game object with tag player

These are some sample codes and their explanation 
Thank you for your valuable time.

Trailer link: https://drive.google.com/drive/folders/1-5fgRt90JthuPtU9JToPwdHaIrzr5lgl

Walk-Through presentation: https://drive.google.com/file/d/1VK0wHLCJBsIvj4WdIH09yO-O2yRb1nt-/view?usp=share_link
