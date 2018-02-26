using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour {

	public Image[] appleColor = new Image[5];
	public Button[] appleButtons = new Button[5];
	public Button wrongButton;
	public Text wrongShape;
	public Text win_text;
	public Image apple;

	void Start() {

		// Hide all colored images initially
		for (int j = 0; j < appleColor.Length; j++) {
			appleColor [j].enabled = false;
		}

		// Hide text & final shape initially
		wrongShape.enabled = false;
		apple.enabled = false;
		win_text.enabled = false;
			
		for (int i = 0; i < appleButtons.Length; i++) {
			int closureIndex = i;
			//Debug.Log(appleButtons[i]);
			appleButtons[i] = appleButtons[i].GetComponent<Button> ();
			appleButtons[closureIndex].onClick.AddListener(() => btnClick(closureIndex));
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
		appleColor [buttonNum].enabled = true;
		appleButtons[buttonNum].gameObject.SetActive(false);
	}

	public void wrongClick () {
		Debug.Log ("wrongClick");
		wrongShape.enabled = true;
		Debug.Break ();
	}

	public bool isWin() {
		bool win = false;
		for (int i = 0; i < appleColor.Length; i++) {
			if (appleColor [i].enabled == false)
				return false;
			else
				win = true;
		}
		return win;
	}

	public void win () {
		apple.enabled = true;
		win_text.enabled = true;
		Debug.Log ("win!");
		Debug.Break ();
	}

}