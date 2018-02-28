using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class banana : MonoBehaviour {

	public Image[] bananaColor = new Image[4];
	public Button[] bananaButtons = new Button[4];
	public Button wrongButton;
	public Text wrongShape;
	public Text win_text;
	public Image bananaFace;

	// Use this for initialization
	void Start () {
		
		// Hide all colored images initially
		for (int j = 0; j < bananaColor.Length; j++) {
			bananaColor [j].enabled = false;
		}

		// Hide text & final shape initially
		wrongShape.enabled = false;
		bananaFace.enabled = false;
		win_text.enabled = false;

		for (int i = 0; i < bananaButtons.Length; i++) {
			int closureIndex = i;
			//Debug.Log(bananaButtons[i]);
			bananaButtons[i] = bananaButtons[i].GetComponent<Button> ();
			bananaButtons[closureIndex].onClick.AddListener(() => btnClick(closureIndex));
		}

		// Wrong button click
		wrongButton = wrongButton.GetComponent<Button> ();
		wrongButton.onClick.AddListener (() => wrongClick ());
	}
	
	// Update is called once per frame
	void Update () {
		if (isWin ())
			win ();
	}

	public void btnClick(int buttonNum) {
		Debug.Log ("buttonNum: " + buttonNum);
		bananaColor [buttonNum].enabled = true;
		bananaButtons[buttonNum].gameObject.SetActive(false);
	}

	public void wrongClick () {
		Debug.Log ("wrongClick");
		wrongShape.enabled = true;
		Debug.Break ();
	}

	public bool isWin() {
		bool win = false;
		for (int i = 0; i < bananaColor.Length; i++) {
			if (bananaColor [i].enabled == false)
				return false;
			else
				win = true;
		}
		return win;
	}

	public void win () {
		bananaFace.enabled = true;
		win_text.enabled = true;
		Debug.Log ("win!");
		Debug.Break ();
	}

}
