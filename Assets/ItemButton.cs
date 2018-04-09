using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/* This class is used to detect press on Shop Item, and if you
 * have enough Neurobucks, you buy it
 * */

public class ItemButton : MonoBehaviour {

	private GameObject ItemManager;
	[HideInInspector]
	public Item holder; //Item associated with this prefab


	void Start () {
		Button btn = this.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		ItemManager = GameObject.FindGameObjectWithTag ("ItemManager");
	}
	
	void TaskOnClick()
	{
		if(ItemManager.GetComponent<ItemManager>().isDecorate == false)	{
			if (ItemManager.GetComponent<ItemManager> ().neurobucks >= holder.getCostNumb ()) {
				ItemManager.GetComponent<ItemManager> ().neurobucks -= holder.getCostNumb ();
				holder.sellItem ();

				if (holder.space == 'a') {
					for (int i = 0; i < 3; i++) {
						if (ItemManager.GetComponent<ItemManager> ().spaceA [i].getId () == holder.getId ()) {
							ItemManager.GetComponent<ItemManager> ().spaceA [i] = holder;
							GetComponentInParent<ShopButton> ().refresh ();
						}
					}
				} else if (holder.space == 'b') {
					for (int i = 0; i < 3; i++) {
						if (ItemManager.GetComponent<ItemManager> ().spaceB [i].getId () == holder.getId ()) {
							ItemManager.GetComponent<ItemManager> ().spaceB [i] = holder;
							GetComponentInParent<ShopButton> ().refresh ();
						}
					}
				} else if (holder.space == 'c') {
					for (int i = 0; i < 3; i++) {
						if (ItemManager.GetComponent<ItemManager> ().spaceC [i].getId () == holder.getId ()) {
							ItemManager.GetComponent<ItemManager> ().spaceC [i] = holder;
							GetComponentInParent<ShopButton> ().refresh ();
						}
					}
				} else if (holder.space == 'd') {
					for (int i = 0; i < 3; i++) {
						if (ItemManager.GetComponent<ItemManager> ().spaceD [i].getId () == holder.getId ()) {
							ItemManager.GetComponent<ItemManager> ().spaceD [i] = holder;
							GetComponentInParent<ShopButton> ().refresh ();
						}
					}
				} else if (holder.space == 'e') {
					for (int i = 0; i < 3; i++) {
						if (ItemManager.GetComponent<ItemManager> ().spaceE [i].getId () == holder.getId ()) {
							ItemManager.GetComponent<ItemManager> ().spaceE [i] = holder;
							GetComponentInParent<ShopButton> ().refresh ();
						}
					}
				}
			}
		}


		if(ItemManager.GetComponent<ItemManager>().isDecorate == true)	{

				if (holder.space == 'a') {
					for (int i = 0; i < 3; i++) {
						if (ItemManager.GetComponent<ItemManager> ().spaceA [i].getId () == holder.getId ()) {
							ItemManager.GetComponent<ItemManager> ().spaceA [i].DecorateDisplay.SetActive (true);
						} else {
							ItemManager.GetComponent<ItemManager> ().spaceA [i].DecorateDisplay.SetActive (false);
						}
					}
				} else if (holder.space == 'b') {
					for (int i = 0; i < 3; i++) {
						if (ItemManager.GetComponent<ItemManager> ().spaceB [i].getId () == holder.getId ()) {
							ItemManager.GetComponent<ItemManager> ().spaceB [i].DecorateDisplay.SetActive (true);
						} else {
							ItemManager.GetComponent<ItemManager> ().spaceB [i].DecorateDisplay.SetActive (false);
						}
					}
				} else if (holder.space == 'c') {
					for (int i = 0; i < 3; i++) {
						if (ItemManager.GetComponent<ItemManager> ().spaceC [i].getId () == holder.getId ()) {
							ItemManager.GetComponent<ItemManager> ().spaceC [i].DecorateDisplay.SetActive (true);
						} else {
							ItemManager.GetComponent<ItemManager> ().spaceC [i].DecorateDisplay.SetActive (false);
						}
					}
				} else if (holder.space == 'd') {
					for (int i = 0; i < 3; i++) {
						if (ItemManager.GetComponent<ItemManager> ().spaceD [i].getId () == holder.getId ()) {
							ItemManager.GetComponent<ItemManager> ().spaceD [i].DecorateDisplay.SetActive (true);
						} else {
							ItemManager.GetComponent<ItemManager> ().spaceD [i].DecorateDisplay.SetActive (false);
						}
					}
				} else if (holder.space == 'e') {
					for (int i = 0; i < 3; i++) {
						if (ItemManager.GetComponent<ItemManager> ().spaceE [i].getId () == holder.getId ()) {
							ItemManager.GetComponent<ItemManager> ().spaceE [i].DecorateDisplay.SetActive (true);
						} else {
							ItemManager.GetComponent<ItemManager> ().spaceE [i].DecorateDisplay.SetActive (false);
						}
					}
				}
		}



	}
}
