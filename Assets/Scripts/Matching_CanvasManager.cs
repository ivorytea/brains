using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matching_CanvasManager : MonoBehaviour {

	public GameObject[] canvas;
	public GameObject scoreCanvas;
	System.Random rnd = new System.Random();
	public bool[] haveSeen;
	private int score = 0;
	public Text scoreText;
	private float timeLeft = 30.0f; // Set to game time in seconds
	public Text timeDisp;
	private bool gameOver = false;

	void Start() {
		scoreCanvas.SetActive (false);
		//scoreText = GetComponent<Text> ();
		switchCanvas ();
	}

	void Update() {
		timeLeft -= Time.deltaTime;
		timeDisp.text = timeLeft.ToString ();
		if ( timeLeft < 0 )
		{
			gameOver = true;
		}

		if (scoreText == null) {
			Debug.Log ("ERR: scoreText set to null");
			Debug.Break ();
		}

		// TODO: refactor
		if (gameOver) {
			Debug.Log ("Score is " + score);
			for (int i = 0; i < canvas.Length; i++)
				canvas [i].SetActive (false);
			scoreCanvas.SetActive (true);
			scoreText.text = score.ToString ();
		}
	}

	void switchCanvas() {

		if (allPlayed ()) {
			// Turn off shapes and move to score screen
			Debug.Log ("Played all shapes");
			Debug.Log ("Score is " + score);
			for(int i = 0; i < canvas.Length; i++)
				canvas [i].SetActive (false);
			// Compute score
			scoreCanvas.SetActive (true);
			scoreText.text = score.ToString ();
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
		score += 10;  // Just adding 10 to score on a win for testing
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
