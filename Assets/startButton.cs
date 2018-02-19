using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startButton : MonoBehaviour {

	public GameObject CanvasManager;

	void Start()
	{
		Button btn = this.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

	}

	void TaskOnClick()
	{
		CanvasManager.GetComponent<CanvasManager> ().CanvasChange (1);
	}
}
