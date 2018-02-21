using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour {

	public GameObject CanvasManager;
	public int changeTo;

	void Start()
	{
		Button btn = this.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

	}

	void TaskOnClick()
	{
		CanvasManager.GetComponent<CanvasManager> ().CanvasChange (changeTo);
	}
}
