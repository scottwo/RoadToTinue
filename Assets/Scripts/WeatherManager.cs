using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeatherManager : MonoBehaviour {

	[SerializeField]
	protected Sprite sun;

	[SerializeField]
	protected Sprite moon;

	[SerializeField]
	protected Sprite rain;

	[SerializeField]
	protected Sprite snow;

	[SerializeField]
	protected Image currWeather;

	// Use this for initialization
	void Start () {
		currWeather.sprite = sun; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
