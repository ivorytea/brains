using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour {

	public Sprite poster;
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

	//Lay out all items available for each space
	private Item[] spaceA = new Item[3];
	private Item[] spaceB = new Item[3];
	private Item[] spaceC = new Item[3];
	private Item[] spaceD = new Item[3];
	private Item[] spaceE = new Item[3];

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class Item {
	private int cost;
	private string name;
	private bool sold;
	private Sprite sprite;

	public Item(int c, string n, Sprite s){
		cost = c;
		name = n;
		sold = false;
		sprite = s;
	}

	public void sellItem(){
		sold = true;
	}

}
