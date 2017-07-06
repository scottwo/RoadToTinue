using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalendarManager : MonoBehaviour {

	[SerializeField]
	protected Text uiText; 

	protected string[] months = new string[8] {
		"Thaw",
		"Equis",
		"Caitelyn",
		"Solace",
		"Lannis",
		"Reaping",
		"Fallow",
		"Dearth"
	};

	protected string[] days = new string[40] {
		"1st","2nd","3rd","4th","5th","6th","7th","8th","9th","10th",
		"11th","12th","13th","14th","15th","16th","17th","18th","19th","20th",
		"21st","22nd","23rd","24th","25th","26th","27th","28th","29th","30th",
		"31st","32nd","33rd","34th","35th","36th","37th","38th","39th","40th",
	};

	protected int currDay = 0;
	protected int currMonth = 0;

	void Start () {
		SetDateCurrent();
	}
	
	void Update () {
		
	}

	protected void SetDateCurrent () {
		string currentDateStr = days[currDay] + "  of  " + months[currMonth];
		uiText.text = currentDateStr;
	}

	public void AdvanceDays (int numOfDays) {
		//Check to change the month.
		if (currDay + numOfDays > 39) {
			//Advance forward one month
			if (currMonth == 7) {
				currMonth = 0;
			} else {
				currMonth += 1;
			}
			//Recurse and advance days in new month minus days to get to 1st of next month.
			int newNumDays = numOfDays - (39 - currDay);
			currDay = -1;
			AdvanceDays(newNumDays);
		} else {
			// Find new day of the month and display it.
			currDay += numOfDays;
			SetDateCurrent();
		}
	}
}
