using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemButton : MonoBehaviour {

	public GameObject ItemManager;
	[HideInInspector]
	public Item holder; //Item associated with this prefab
	// Use this for initialization
	void Start () {
		Button btn = this.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	
	void TaskOnClick()
	{
		
		if (ItemManager.GetComponent<ItemManager> ().neurobucks >= holder.getCostNumb ()) {

		}
	}
}
