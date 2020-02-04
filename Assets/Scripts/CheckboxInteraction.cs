using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckboxInteraction : MonoBehaviour
{
    public GameObject buttonIdle;
    private static bool isChecked;
    Material checkedOff;
    Material wireframe;

    void Start()
    {
        isChecked = false;
        //setting the materials
        checkedOff = Resources.Load("check", typeof(Material)) as Material;
        wireframe = Resources.Load("wireframe", typeof(Material)) as Material;
    }
    
    public void ChangeMaterial()
    {     
        //if the box is tapped, change the material
        if (isChecked == false)
        {
            buttonIdle.GetComponent<Renderer>().material = checkedOff;
            isChecked = true;
        }
        else
        {
            buttonIdle.GetComponent<Renderer>().material = wireframe;
            isChecked = false;
        }   
    }
}
