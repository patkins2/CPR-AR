using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyUIManager : MonoBehaviour {

    [SerializeField] GameObject buttonConnect, button130;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowAllButtons()
    {
        buttonConnect.SetActive(true);
        button130.SetActive(true);
    }

    public void HideAllButtons()
    {
        buttonConnect.SetActive(false);
        button130.SetActive(false);
    }

}
