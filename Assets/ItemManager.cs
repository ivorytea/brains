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

	// Use this for initialization
	void Start () {
		yVal = -926;
		xVal = 2487;
		startXVal = xVal;
		incXVal = 50;
		Item brainP = new Item (50, brainPoster);
		Item hangP = new Item (50, hangPoster);
		Item bottleShelf = new Item (100, bottles);
		spaceA = new Item[] { brainP, hangP, bottleShelf }; 
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
					activeShopItems [numbOfItems] = Instantiate (itemUIPrefab, new Vector3 (xVal, yVal, 1),Quaternion.identity);
					activeShopItems [numbOfItems].transform.SetParent (parent);
					activeShopItems [numbOfItems].transform.Translate (incXVal * numbOfItems,0,0);
					activeShopItems [numbOfItems].GetComponent<Image> ().sprite = spaceA [i].getSprite ();
					activeShopItems [numbOfItems].GetComponentInChildren<Text> ().text = spaceA [i].getCost();
					xVal += incXVal;
					numbOfItems++;
				}
			}

		} else if (space == 'b') {

		} else if (space == 'c') {

		} else if (space == 'd') {

		} else if (space == 'e') {

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
			xVal = startXVal;
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

}
