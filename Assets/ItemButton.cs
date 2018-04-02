using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/* This class is used to detect press on Shop Item, and if you
 * have enough Neurobucks, you buy it
 * */

public class ItemButton : MonoBehaviour {

	public GameObject ItemManager;
	[HideInInspector]
	public Item holder; //Item associated with this prefab


	void Start () {
		Button btn = this.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	
	void TaskOnClick()
	{
		
		if (ItemManager.GetComponent<ItemManager> ().neurobucks >= holder.getCostNumb ()) {
			ItemManager.GetComponent<ItemManager> ().neurobucks -= holder.getCostNumb ();
			holder.sellItem ();

			if (holder.space == 'a') {
				for(int i = 0; i < 3; i++)
				{
					if (ItemManager.GetComponent<ItemManager> ().spaceA [i].getSprite == holder.getSprite) {
						ItemManager.GetComponent<ItemManager> ().spaceA [i] = holder;
						GetComponentInParent<ShopButton> ().refresh();
					}
				}
			}
			else if (holder.space == 'b') {
				for(int i = 0; i < 3; i++)
				{
					if (ItemManager.GetComponent<ItemManager> ().spaceB [i].getSprite == holder.getSprite) {
						ItemManager.GetComponent<ItemManager> ().spaceB [i] = holder;
						GetComponentInParent<ShopButton> ().refresh();
					}
				}
			}
			else if (holder.space == 'c') {
				for(int i = 0; i < 3; i++)
				{
					if (ItemManager.GetComponent<ItemManager> ().spaceC [i].getSprite == holder.getSprite) {
						ItemManager.GetComponent<ItemManager> ().spaceC [i] = holder;
						GetComponentInParent<ShopButton> ().refresh();
					}
				}
			}
			else if (holder.space == 'd') {
				for(int i = 0; i < 3; i++)
				{
					if (ItemManager.GetComponent<ItemManager> ().spaceD [i].getSprite == holder.getSprite) {
						ItemManager.GetComponent<ItemManager> ().spaceD [i] = holder;
						GetComponentInParent<ShopButton> ().refresh();
					}
				}
			}
			else if (holder.space == 'e') {
				for(int i = 0; i < 3; i++)
				{
					if (ItemManager.GetComponent<ItemManager> ().spaceE [i].getSprite == holder.getSprite) {
						ItemManager.GetComponent<ItemManager> ().spaceE [i] = holder;
						GetComponentInParent<ShopButton> ().refresh();
					}
				}
			}

		}
	}
}
