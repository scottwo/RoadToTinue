using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtons : MonoBehaviour {
	
	public void QuitGame () {
		Application.Quit();
	}

	public void NewGame () {
		SceneManager.LoadScene("game");
	}

	public void LoadGame () {
		Debug.Log("Game loaded!");
	}

	public void OpenSettings () {
		Debug.Log("Settings ready for setting.");
	}

}
