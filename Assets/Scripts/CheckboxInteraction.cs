using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckboxInteraction : MonoBehaviour
{
    public GameObject buttonIdle;
    private bool isChecked;
    void Start()
    {
         isChecked = false;
    }
    
    public void ChangeMaterial()
    {
        //setting the materials
        Material checkedOff = Resources.Load("check", typeof(Material)) as Material;
        Material wireframe = Resources.Load("wireframe", typeof(Material)) as Material;

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
