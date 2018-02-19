using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour {

	private GameObject activeCanvas;

	public GameObject canvas0; //Main Menu
	public GameObject canvas1; //First panel hub

	public GameObject hubCanvas;
	public GameObject panel;

	private bool onMM; //Says if we are on the main menu or not
	// Use this for initialization
	void Start () {
		Debug.Log ("Hey activating Canvas!");
		activeCanvas = canvas0; //First active canvas is the main menu
		activeCanvas.SetActive(true);
		onMM = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Canvas Change assigns different panel configurations a number, and based on
	//that will say which one to enable and will disable the current active canvas
	public void CanvasChange(int newCanvas)
	{
		activeCanvas.SetActive(false);

		//Going to anywhere but the main menu
		if (newCanvas != 0) {
			
			//Checks to see if we are leaving the main menu and, if so, turns on the neccessary components
			if (onMM == true) {
				onMM = false;
				hubCanvas.SetActive (true);
				panel.SetActive (true);
			}
			if (newCanvas == 1) {
				activeCanvas = canvas1;
			}

			//Going to the main menu
		} else {

			//Checks to see if we are entering the main menu and, if so, turns off certain components
			if (onMM == false) {
				onMM = true;
				hubCanvas.SetActive (false);
				panel.SetActive (false);
			}
		}

		activeCanvas.SetActive(true);
		Debug.Log ("Hey Canvas " + newCanvas + " was activated");	


	}
}
