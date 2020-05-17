using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckboxInteraction : MonoBehaviour
{
    public GameObject buttonIdle;
    public bool isChecked;
    public static Material checkedOff;
    public static Material wireframe;

    void Start()
    {
        isChecked = false;

        //setting the materials
        checkedOff = Resources.Load("check", typeof(Material)) as Material;
        wireframe = Resources.Load("wireframe", typeof(Material)) as Material;
    }

    private void Update()
    {
        //if the box is tapped, change the material
        if (isChecked == true)
        {
            buttonIdle.GetComponent<Renderer>().material = checkedOff;
        }
        if (isChecked == false)
        {
            buttonIdle.GetComponent<Renderer>().material = wireframe;
        }
    }
}