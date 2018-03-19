using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shapes_CanvasManager : MonoBehaviour {

	public GameObject[] canvas;
	System.Random rnd = new System.Random();
	public bool[] haveSeen;

	void Start() {
		//for (int i = 0; i < haveSeen.Length; i++)
		switchCanvas ();
	}

	void switchCanvas() {

		if (allPlayed ()) {
			Debug.Break ();
		}

		else {
			// generate new canvas
			int idx = generateRandomCanvas ();
			// find shape not yet played
			while (played(idx))
				idx = generateRandomCanvas ();
			// turn on canvas
			canvas[idx].SetActive (true);
			// turn off other canvases
			for (int i = 0; i < canvas.Length; i++) {
				if (i != idx) 
					canvas [i].SetActive (false);
			}
			haveSeen [idx] = true;
		}
	}

	// Called from Shape.cs if shape is won
	public void winDetected(bool win) {
			switchCanvas();
	}

	// Determines if a shape has been played
	// Returns: true if shape has been played, 
	//          false if not yet played
	bool played(int idx) {
		if (haveSeen [idx])
			return true;
		return false;
	}

	// Generates the index of a random canvas
	// Returns: randomly generated index
	int generateRandomCanvas() {
		int idx = rnd.Next (1, canvas.Length);
		return idx;
	}

	// Determines if all shapes have been played
	// Returns: false if outstanding shapes remain, 
	//          true if all are played
	bool allPlayed() {
		for(int i = 0; i < canvas.Length; i++) {
			if (!haveSeen[i])
				return false;
		}
		return true;
	}
}