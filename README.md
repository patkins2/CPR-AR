# CPR-AR

This is a CPR Manuel/Trainer for Hololens made with Unity. The application displays a small menu box, or "panel," that will display steps/inscrutions for performing CPR. The steps are based on document provided by the Charlotte Fire Department.

# Features
**There are two current versions of the application**
  - The scene "CPR" shows one menu with multiple inscuctions
  - The scene "one_line" show one instruction at a time.
  - **The scene "test" is only present to test features that could cause issues with current working versions, and it is recommended you don't build off of this scene. If you need to test new features, make a duplicate of your scene and rename it to text and remove the old one.**

***"one_line" is the recommended scene. As some of the features described below are not present in "CPR"***

As with the menu previously described, features also include voice commands, a metronome, and a 3D avatar placed in the scene if the user wishes to simulate using the app in the field.
The application could also be used for someone making an assesment. Each instruction has a small checkbox that the user can check off to help keep track of progress.

Voice Commands include:
  - Hiding/Showing indiviual or all UI components
    - i.e. "Hide Buttons," "Hide Panel," "Hide All," "Hide Avatar," and vice versa.
  - Menu Navigation
    - i.e. User can say "Next Page," "Go Back," "Begin," or "Restart."
  - 110 BPM Metronome
    - i.e. User can say "One Ten" to start the metronome and "Stop" to stop it. 

# Current issues
  - ~~When running on the hololens, the checkbox becomes rather large when the cursor is not touching it.~~
  - Buttons don't move with the panel perfectly.


Future Additions
  - [ ] Embedded Videos and Pictures
  - [x] ~~Checkbox will change the page after a few seconds.~~
  - [x] ~~Summary once completed~~
  - [ ] Set up using a real mannequin with some image detection library (probably Vuforia)

# Notes
- Hololens 1st Gen
- Unity Version: 2018.4.12f1
- HoloToolkit Version : 2017.4.1.0
