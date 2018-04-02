using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemManager : MonoBehaviour {

	public Sprite brainPoster;
	public Sprite hangPoster;
	public Sprite bottles;
	public Sprite ovalRug;
	public Sprite starRug;
	public Sprite squareRug;
	public Sprite blinds;
	public Sprite curtains;
	public Sprite windows;
	public Sprite dumbell;
	public Sprite bag;
	public Sprite jumpRope;
	public Sprite bike;
	public Sprite mirror;
	public Sprite treadmill;

	public GameObject itemUIPrefab;
	private GameObject[] activeShopItems = new GameObject[3];
	private int numbOfItems = 0; //Number of items shown in the current shop/decorate UI

	private float yVal;
	private float xVal;
	private float startXVal;
	private float incXVal;

	//Lay out all items available for each space
	private Item[] spaceA = new Item[3];
	private Item[] spaceB = new Item[3];
	private Item[] spaceC = new Item[3];
	private Item[] spaceD = new Item[3];
	private Item[] spaceE = new Item[3];


	public int neurobucks = 0;
	// Use this for initialization
	void Start () {
		//yVal = -926;
		//xVal = 2487;
		//startXVal = xVal;
		incXVal = 80;

		Item blindsItem = new Item (50, blinds);
		Item curtainsItem = new Item (50, curtains);
		Item windowsItem = new Item (100, windows);
		spaceA = new Item[] { blindsItem, curtainsItem, windowsItem }; 

		Item dumbellItem = new Item (50, dumbell);
		Item bagItem = new Item (50, bag);
		Item jumpRopeItem = new Item (100, jumpRope);
		spaceB = new Item[] { dumbellItem, bagItem, jumpRopeItem }; 

		Item bikeItem = new Item (50, bike);
		Item mirrorItem = new Item (50, mirror);
		Item treadmillItem = new Item (100, treadmill);
		spaceC = new Item[] { bikeItem, mirrorItem, treadmillItem }; 

		Item ovalRugItem = new Item (50, ovalRug);
		Item squareRugItem = new Item (50, squareRug);
		Item starRugItem = new Item (100, starRug);
		spaceD = new Item[] { ovalRugItem, squareRugItem, starRugItem }; 

		Item brainPItem = new Item (50, brainPoster);
		Item hangPItem = new Item (50, hangPoster);
		Item bottleShelfItem = new Item (100, bottles);
		spaceE = new Item[] { brainPItem, hangPItem, bottleShelfItem }; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void displayShopItems(char space, bool isShop, Transform parent)
	{
		refreshShopItems ();
		if (space == 'a') {
			for(int i = 0; i < spaceA.Length; i++)
			{
				if(spaceA[i].getSold() == false){
					//Instatiate Item based on Prefab
					activeShopItems [numbOfItems] = Instantiate (itemUIPrefab, new Vector3 (0, 0, 1),Quaternion.identity);
					//Set it to be a parent of the space game object
					activeShopItems [numbOfItems].transform.SetParent (parent);
					//Depending on how many items are in the list for that space, space them out
					activeShopItems [numbOfItems].transform.Translate (incXVal * numbOfItems,-30,0);
					//Depending on what item it is, get the sprite and make it the new image 
					activeShopItems [numbOfItems].GetComponent<Image> ().sprite = spaceA [i].getSprite ();
					//Depending on what item it is, get the cost and make it the new text
					activeShopItems [numbOfItems].GetComponentInChildren<Text> ().text = spaceA [i].getCost();
					//Attach item to itemButton script in Prefab
					activeShopItems [numbOfItems].GetComponent<ItemButton>().holder = spaceA[i];
					//Number of items displayed increases
					numbOfItems++;
				}
			}

		} else if (space == 'b') {
			for(int i = 0; i < spaceB.Length; i++)
			{
				if(spaceB[i].getSold() == false){
					//Instatiate Item based on Prefab
					activeShopItems [numbOfItems] = Instantiate (itemUIPrefab, new Vector3 (0, 0, 1),Quaternion.identity);
					//Set it to be a parent of the space game object
					activeShopItems [numbOfItems].transform.SetParent (parent);
					//Depending on how many items are in the list for that space, space them out
					activeShopItems [numbOfItems].transform.Translate (incXVal * numbOfItems,-30,0);
					//Depending on what item it is, get the sprite and make it the new image 
					activeShopItems [numbOfItems].GetComponent<Image> ().sprite = spaceB [i].getSprite ();
					//Depending on what item it is, get the cost and make it the new text
					activeShopItems [numbOfItems].GetComponentInChildren<Text> ().text = spaceB [i].getCost();
					//Attach item to itemButton script in Prefab
					activeShopItems [numbOfItems].GetComponent<ItemButton>().holder = spaceB[i];
					//Number of items displayed increases
					numbOfItems++;
				}
			}

		} else if (space == 'c') {
			for(int i = 0; i < spaceC.Length; i++)
			{
				if(spaceC[i].getSold() == false){
					//Instatiate Item based on Prefab
					activeShopItems [numbOfItems] = Instantiate (itemUIPrefab, new Vector3 (0, 0, 1),Quaternion.identity);
					//Set it to be a parent of the space game object
					activeShopItems [numbOfItems].transform.SetParent (parent);
					//Depending on how many items are in the list for that space, space them out
					activeShopItems [numbOfItems].transform.Translate (incXVal * numbOfItems,-30,0);
					//Depending on what item it is, get the sprite and make it the new image 
					activeShopItems [numbOfItems].GetComponent<Image> ().sprite = spaceC [i].getSprite ();
					//Depending on what item it is, get the cost and make it the new text
					activeShopItems [numbOfItems].GetComponentInChildren<Text> ().text = spaceC [i].getCost();
					//Attach item to itemButton script in Prefab
					activeShopItems [numbOfItems].GetComponent<ItemButton>().holder = spaceC[i];
					//Number of items displayed increases
					numbOfItems++;
				}
			}


		} else if (space == 'd') {
			for(int i = 0; i < spaceD.Length; i++)
			{
				if(spaceD[i].getSold() == false){
					//Instatiate Item based on Prefab
					activeShopItems [numbOfItems] = Instantiate (itemUIPrefab, new Vector3 (0, 0, 1),Quaternion.identity);
					//Set it to be a parent of the space game object
					activeShopItems [numbOfItems].transform.SetParent (parent);
					//Depending on how many items are in the list for that space, space them out
					activeShopItems [numbOfItems].transform.Translate (incXVal * numbOfItems,-30,0);
					//Depending on what item it is, get the sprite and make it the new image 
					activeShopItems [numbOfItems].GetComponent<Image> ().sprite = spaceD [i].getSprite ();
					//Depending on what item it is, get the cost and make it the new text
					activeShopItems [numbOfItems].GetComponentInChildren<Text> ().text = spaceD [i].getCost();
					//Attach item to itemButton script in Prefab
					activeShopItems [numbOfItems].GetComponent<ItemButton>().holder = spaceD[i];
					//Number of items displayed increases
					numbOfItems++;
				}
			}

		} else if (space == 'e') {
			for(int i = 0; i < spaceE.Length; i++)
			{
				if(spaceE[i].getSold() == false){
					//Instatiate Item based on Prefab
					activeShopItems [numbOfItems] = Instantiate (itemUIPrefab, new Vector3 (0, 0, 1),Quaternion.identity);
					//Set it to be a parent of the space game object
					activeShopItems [numbOfItems].transform.SetParent (parent);
					//Depending on how many items are in the list for that space, space them out
					activeShopItems [numbOfItems].transform.Translate (incXVal * numbOfItems,-30,0);
					//Depending on what item it is, get the sprite and make it the new image 
					activeShopItems [numbOfItems].GetComponent<Image> ().sprite = spaceE [i].getSprite ();
					//Depending on what item it is, get the cost and make it the new text
					activeShopItems [numbOfItems].GetComponentInChildren<Text> ().text = spaceE [i].getCost();
					//Attach item to itemButton script in Prefab
					activeShopItems [numbOfItems].GetComponent<ItemButton>().holder = spaceE[i];
					//Number of items displayed increases
					numbOfItems++;
				}
			}

		} else {
			Debug.Log ("Uhh.....well this shouldn't happen");
		}
	}

	public void refreshShopItems()
	{
		if (numbOfItems != 0) {
			for (int i = 0; i < activeShopItems.Length; i++) {
				GameObject.Destroy (activeShopItems [i].gameObject);
				Debug.Log ("WOOT DESTROY " + i);
			}
			//xVal = startXVal;
			activeShopItems = new GameObject[3];
			numbOfItems = 0;
		}
	}
}

public class Item {
	private int cost;
	private bool sold;
	private Sprite sprite;

	public Item(int c, Sprite s){
		cost = c;
		sold = false;
		sprite = s;
	}

	public void sellItem(){
		sold = true;
	}

	public bool getSold(){
		return sold;
	}

	public Sprite getSprite(){
		return sprite;
	}

	public string getCost(){
		return cost.ToString();
	}

		public int getCostNumb(){
			return cost;
		}

}

