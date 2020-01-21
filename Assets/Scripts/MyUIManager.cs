using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyUIManager : MonoBehaviour
{

    [SerializeField] GameObject buttonConnect, panel;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowAllButtons()
    {
        buttonConnect.SetActive(true);
    }

    public void HideAllButtons()
    {
        buttonConnect.SetActive(false);
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
        buttonConnect.SetActive(false);
        panel.SetActive(false);
    }
    public void ShowAll()
    {
        buttonConnect.SetActive(true);
        panel.SetActive(true);
    }
}
