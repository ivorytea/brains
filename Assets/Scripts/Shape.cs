using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour {

	//public Image[] appleColor = new Image[5];
	public Image[] shapeColor;
	//public Button[] appleButtons = new Button[5];
	public Button[] shapeButtons;
	public Button wrongButton;
	public Image wrongShape;
	public Text win_text;
	public Image shapeFace;

	public Shapes_CanvasManager canvasManager;

	void Start() {

		// Hide all colored images initially
		for (int i = 0; i < shapeColor.Length; i++) {
			shapeColor [i].enabled = false;
		}

		// Hide text & final shape initially

		wrongShape.enabled = false;
		shapeFace.enabled = false;
		win_text.enabled = false;
			
		for (int i = 0; i < shapeButtons.Length; i++) {
			int closureIndex = i;
			//Debug.Log(appleButtons[i]);
			shapeButtons[i] = shapeButtons[i].GetComponent<Button> ();
			shapeButtons[closureIndex].onClick.AddListener(() => btnClick(closureIndex));
		}

		// Wrong button click
		wrongButton = wrongButton.GetComponent<Button> ();
		wrongButton.onClick.AddListener (() => wrongClick ());
	}

	void Update() {
		if (isWin ())
			win ();
	}

	public void btnClick(int buttonNum) {
		Debug.Log ("buttonNum: " + buttonNum);
		shapeColor [buttonNum].enabled = true;
		shapeButtons[buttonNum].gameObject.SetActive(false);
	}

	public void wrongClick () {
		Debug.Log ("wrongClick");
		wrongShape.enabled = true;
		Debug.Break ();
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
		shapeFace.enabled = true;
		win_text.enabled = true;
		Debug.Log ("win!");
		canvasManager.winDetected (true); // NullReferenceException: Object reference not set to an instance of an object
	}
}