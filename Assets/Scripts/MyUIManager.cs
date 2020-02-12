using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyUIManager : MonoBehaviour
{
    [SerializeField] GameObject nextButton, panel, backButton, avatar;
 
    //functions that enable or disable the button and panel
    public void ShowAllButtons()
    {
        nextButton.SetActive(true);
        backButton.SetActive(true);
    }

    public void HideAllButtons()
    {
        nextButton.SetActive(false);
        backButton.SetActive(false);
    }

    public void HidePanel()
    {
        panel.SetActive(false);
    }

    public void ShowPanel()
    {
        panel.SetActive(true);
    }

    public void ShowAvatar()
    {
        avatar.SetActive(true);
    }

    public void HideAvatar()
    {
        avatar.SetActive(false);
    }
    public void HideAll()
    {
        nextButton.SetActive(false);
        panel.SetActive(false);
        backButton.SetActive(false);
        avatar.SetActive(false);
    }
    public void ShowAll()
    {
        nextButton.SetActive(true);
        panel.SetActive(true);
        backButton.SetActive(true);
        avatar.SetActive(false);
    }
}
