using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

using LitJson;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

	protected Inventory playterInv = new Inventory();
	protected JsonData invData;

	public Inventory GetPlayerInv() {
		return playterInv;
	}

}

public class Inventory {
	//Add items obtainable to this class as public ints. Each property will list how many of that item the player currently has.

	protected List<Item> inventory = new List<Item>();

}

public class Item {
	public int ID { get; set; }
	public string Name { get; set; }

	public Item(int id, string name) {
		this.ID = id;
		this.Name = name;
	}
}