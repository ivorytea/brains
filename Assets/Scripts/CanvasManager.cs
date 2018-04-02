using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour {

	private GameObject activeCanvas;

	public GameObject canvas0; //Main Menu
	public GameObject canvas1; //First panel hub
	public GameObject canvas2; //Puzzle Hub
	public GameObject canvas3; //Shopping Hub
	public GameObject canvas4; //Options hub

	private GameObject activeSpeech; //active speech bubble

	public GameObject speechPuzzles;
	public GameObject speechOptions;

	public GameObject hubCanvas;
	public GameObject panel;

	public GameObject brainChar;
	public GameObject brainCav; //brain Cavity

	public GameObject itemManager;

	private bool onMM; //Says if we are on the main menu or not
	private Animator pAnim; //Animator for panel
	private Animator cAnim; //Animator for character
	private Animator bcAnim; //Animator for brain cavity

	// Use this for initialization
	void Start () {
		Debug.Log ("Hey activating Canvas!");
		activeCanvas = canvas0; //First active canvas is the main menu
		activeCanvas.SetActive(true);
		activeSpeech = speechPuzzles; //Setting a default active speech bubble
		activeSpeech.SetActive(false); //No speech bubble in the beginning
		pAnim = panel.GetComponent<Animator>();
		cAnim = brainChar.GetComponent<Animator> ();
		bcAnim = brainCav.GetComponent<Animator> ();
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
				pAnim.SetInteger ("State", 1);
				cAnim.SetBool ("isSmall", false);
				bcAnim.SetBool ("isSmall", false);
			}
			else if (newCanvas == 2) {
				activeCanvas = canvas2;
				pAnim.SetInteger ("State", 2);
				cAnim.SetBool ("isSmall", true);
				bcAnim.SetBool ("isSmall", true);
				activeSpeech.SetActive (false);
				activeSpeech = speechPuzzles;
				activeSpeech.SetActive (true);
			}
			else if (newCanvas == 3) {
				activeCanvas = canvas3;
				pAnim.SetInteger ("State", 3);
				cAnim.SetBool ("isSmall", true);
				bcAnim.SetBool ("isSmall", true);
				activeSpeech.SetActive (false);
				activeSpeech = speechPuzzles;
				activeSpeech.SetActive (true);
				//ItemManager.GetComponent<ItemManager> ().displayShopItems ('a',true,parent);
			}
			else if (newCanvas == 4) {
				activeCanvas = canvas4;
				pAnim.SetInteger ("State", 4);
				cAnim.SetBool ("isSmall", true);
				bcAnim.SetBool ("isSmall", true);
				activeSpeech.SetActive (false);
				activeSpeech = speechOptions;
				activeSpeech.SetActive (true);
			}

			//Going to the main menu
		} else {
			pAnim.SetInteger ("State", 0);
			cAnim.SetBool ("isSmall", false);
			bcAnim.SetBool ("isSmall", false);
			//Checks to see if we are entering the main menu and, if so, turns off certain components
			if (onMM == false) {
				onMM = true;
				hubCanvas.SetActive (false);
				panel.SetActive (false);
				activeSpeech.SetActive (false);
				activeCanvas = canvas0;
			}
		}

		activeCanvas.SetActive(true);
		Debug.Log ("Hey Canvas " + newCanvas + " was activated");	


	}
}
