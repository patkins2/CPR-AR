using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeText : MonoBehaviour
{
    public Text displayText; //the text that is displayed
    private int counter; //counter used for change the information on the menu

    public void Start()
    {
        //displayText.text = "Press Ok to Begin";
        counter = 1;
    }

    void Update()
    {
        //Press the space key to change the Text message
        /*if (Input.GetKey(KeyCode.Space))
        {
            displayText.text = "My text has now changed.";
        }*/
    }

    public void Test() //will get called when the button is pressed
    {
        //the value of counter will determine which screen is displayed. More can be added, just create more cases.
        switch (counter)
        {
            case 1:
                displayText.text = "Is the Scene Safe?" + "\n" + "Personal Protective Equipment" + "\n" + "Check Number of Patients" + "\n" + "Medical or Trauma";
                counter++;
                break;
            case 2:
                displayText.text = "AVPU" + "\n" + "Check Carotid & Breathing for 5-10 secs" + "\n" + "Immediate High-Quality Compressions" + "\n" + "Announce 1st & every 20th compression" + "\n" + "Depth of 2 inches" + "\n" + "Change every 200th compression";
                counter++;
                break;
            case 3:
                displayText.text = "Open the Airway" + "\n" + "Clear Airway as Needed" + "\n" + "Assists Ventilations with BVM" + "\n" + "Provide High Flow Oxygen to BVM";
                counter++;
                break;
            case 4:
                displayText.text = "Choose Correct Size" + "\n" + "Test Cuff(King)" + "\n" + "Lubricate Distal End of Tube" + "\n" + "Perform a Tongue-Jaw Lift (King)" + "\n" + "Insert Tube into Corner of Mouth" + "\n" + " Blue Line Should Face the Chin (King)"
                    + "\n" + "Colored Adapter at the Level of the Lips (King)" + "\n" + "Inflate Cuff(King)" + "\n" + "Attach BVM" + "\n" + "Confirm Tube Placemen" + "\n" + "Measure and Insert OG (King)" + "\n" + "Suction OG/NG/Mouth as Needed"
                    + "\n" + "Secure Tube to Patient";
                counter++;
                break;
            case 5:
                displayText.text = "Bear paitient's chest" + "\n" + "Apply Pads" + "\n" + "Turn on the defib" + "\n" + "Place QCPR Puck on Chest" + "\n" + "Coach compressor for depth,rate,& recoil" + "\n" + "Ready Next Compressor" + "\n"
                    + "Palpate Femoral Pulse from 180th-200th Compressions" + "\n" + "Analyze at 200th Compression" + "\n" + "Clear All Personnel" + "\n" + "Shoch as advised" + "\n" + "Immediately Direct Next Compressor to Begin";
                counter++;
                break;

            default:
                displayText.text = "Press OK to begin"; //assuming you've been through the whole menu, counter will reset to 1
                counter = 1;
                break;
        }
    }
    public void Next() //for voice commands
    {
        counter++;
    }

    public void StartOver()
    {
        SceneManager.LoadScene("CPR");
    }
}
