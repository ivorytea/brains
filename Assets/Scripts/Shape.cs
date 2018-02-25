using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour {

	public Image[] appleColor = new Image[5];
	public Button[] appleButtons = new Button[5];

	void Start() {

		//Button[] btns = new Button[appleButtons.Length];

		// Hide all colored images initially
		for (int j = 0; j < appleColor.Length; j++) {
			appleColor [j].enabled = false;
		}
			
		for (int i = 0; i < appleButtons.Length; i++) {
			int closureIndex = i;
			//Debug.Log(appleButtons[i]);
			appleButtons[i] = appleButtons[i].GetComponent<Button> ();
			appleButtons[closureIndex].onClick.AddListener(() => btnClick(closureIndex));
		}
	}

	public void btnClick(int buttonNum) {
		Debug.Log ("buttonNum: " + buttonNum);
		appleColor [buttonNum].enabled = true;
		appleButtons[buttonNum].gameObject.SetActive(false);
	}
}