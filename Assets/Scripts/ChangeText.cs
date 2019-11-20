using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    public Text displayText; //the text that is displayed
    public int counter; //counter for screen navigation

    void Start()
    {
        //Text sets your text to say this message
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

    public void Test()
    {
        //the value of counter will determine which screen is displayed. More can be added, just create more cases.
        switch (counter)
        {
            case 1:
                displayText.text = "1st Screen";
                counter++;
                break;
            case 2:
                displayText.text = "2nd Screen";
                counter++;
                break;
            case 3:
                displayText.text = "3rd Screen";
                counter++;
                break;

            default:
                displayText.text = "Press OK to begin"; //assuming you've been through the whole menu, counter will reset to 1
                counter = 1;
                break;
        }
        //displayText.text = "test";
    } 
}
