using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    //Because of the way this app runs, resetting the timer, and displaying the info is handled in ChangeText.cs

    public float timeElapsed;
    GameObject checkbox;
    public TextMeshPro timerText;
         
    // Start is called before the first frame update
    void Start()
    {
        checkbox = GameObject.FindGameObjectWithTag("checkbox");
        timeElapsed = 0;
    }

    void Update()
    {
        if(checkbox.activeSelf == true)
        {
            timeElapsed += Time.deltaTime; //track the elapsed timer
            timerText.gameObject.SetActive(false); //turn off the text while going through the menu
        }
        else
        {
            timerText.gameObject.SetActive(true); //turn on the text
            //rounding the number and displaying the text is handled in ChangeText.OneLine()
        }
    }
}
