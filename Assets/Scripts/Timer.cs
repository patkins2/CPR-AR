using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    double timeElapsed;
    GameObject timerObj;
    string scr; 
        
    // Start is called before the first frame update
    void Start()
    {
        timerObj = GameObject.FindGameObjectWithTag("timer");
        scr = "Timer";
    }

    // Update is called once per frame
    void Update()
    {
        if (ChangeText.counter != 0)
            timeElapsed += Time.deltaTime;
        else
        {
            Debug.Log(timeElapsed);
            (timerObj.GetComponent(scr) as MonoBehaviour).enabled = false;
        }
    }
}
