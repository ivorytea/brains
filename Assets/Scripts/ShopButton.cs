using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour {

	public GameObject ItemManager;
	public char space;

	private Transform parent;

	void Start()
	{
		Button btn = this.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		parent = transform;

	}

	void TaskOnClick()
	{
		ItemManager.GetComponent<ItemManager> ().displayShopItems (space,parent);
	}

	public void refresh()
	{
		ItemManager.GetComponent<ItemManager> ().displayShopItems (space,parent);
	}

}
