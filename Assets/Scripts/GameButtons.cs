using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameButtons : MonoBehaviour {

	public void OpenInventory() {
		Debug.Log("Inventory Opened.");
	}

	public void OpenJournal() {
		Debug.Log("Opened Journal.");
	}

	public void OpenMenu() {
		//Just quit for now.
		Application.Quit();
	}

}
