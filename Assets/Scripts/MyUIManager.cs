using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyUIManager : MonoBehaviour
{
    [SerializeField] GameObject okButton, panel;
 
    //functions that enable or disable the button and panel
    public void ShowAllButtons()
    {
        okButton.SetActive(true);
    }

    public void HideAllButtons()
    {
        okButton.SetActive(false);
    }

    public void HidePanel()
    {
        panel.SetActive(false);
    }

    public void ShowPanel()
    {
        panel.SetActive(true);
    }

    public void HideAll()
    {
        okButton.SetActive(false);
        panel.SetActive(false);
    }
    public void ShowAll()
    {
        okButton.SetActive(true);
        panel.SetActive(true);
    }
}
