using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    public Text displayText;

    void Start()
    {
        //Text sets your text to say this message
        //displayText.text = "Press Ok to Begin";
    }

    void Update()
    {
        //Press the space key to change the Text message
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    displayText.text = "My text has now changed.";
        //}
    }

    public void Test()
    {
        //displayText = GetComponent<TextMesh>();
        //TextMesh t = (TextMesh)gameObject.GetComponent(typeof(TextMesh));
        //t.text = "test";
        displayText.text = "test";
    }
    
   
}
