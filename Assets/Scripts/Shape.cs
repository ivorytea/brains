using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour {

	public Image[] shapeColor;
	public Button[] shapeButtons;
	public Button wrongButton;
	public Image wrongShape;
	public Image shapeFace;

	public Shapes_CanvasManager canvasManager;

	void Start() {

		// Hide all colored images initially
		for (int i = 0; i < shapeColor.Length; i++) {
			shapeColor [i].enabled = false;
		}

		// Hide final shape and X initially
		wrongShape.enabled = false;
		shapeFace.enabled = false;
			
		for (int i = 0; i < shapeButtons.Length; i++) {
			int closureIndex = i;
			shapeButtons[i] = shapeButtons[i].GetComponent<Button> ();
			shapeButtons[closureIndex].onClick.AddListener(() => btnClick(closureIndex));
		}

		// Wrong button click
		wrongButton = wrongButton.GetComponent<Button> ();
		wrongButton.onClick.AddListener (() => wrongClick ());
	}

	void Update() {
		if (isWin ()) {
			win ();
			StartCoroutine (pauseWin());
		}
	}

	public void btnClick(int buttonNum) {
		Debug.Log ("buttonNum: " + buttonNum);
		shapeColor [buttonNum].enabled = true;
		shapeButtons[buttonNum].gameObject.SetActive(false);
	}

	public void wrongClick () {
		Debug.Log ("wrongClick");
		wrongShape.enabled = true;
		// Reset shape
		for (int i = 0; i < shapeColor.Length; i++)
			shapeColor [i].enabled = false;
		// Reset buttons
		for (int i = 0; i < shapeButtons.Length; i++)
			shapeButtons [i].gameObject.SetActive (true);
		StartCoroutine (pauseWrong ());
	}

	public void resetX() {
		wrongShape.enabled = false;
	}

	public bool isWin() {
		bool win = false;
		for (int i = 0; i < shapeColor.Length; i++) {
			if (shapeColor [i].enabled == false)
				return false;
			else
				win = true;
		}
		return win;
	}

	public void win () {
		Debug.Log ("Win!");
		shapeFace.enabled = true;
	}
		
	IEnumerator pauseWin() {
		yield return new WaitForSeconds (2);
		canvasManager.winDetected (true);
	}

	// TODO: Ditto
	IEnumerator pauseWrong() {
		yield return new WaitForSeconds (2);
		Debug.Log ("Delaying...");
		resetX ();
	}
}