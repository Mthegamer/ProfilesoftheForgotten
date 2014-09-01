using UnityEngine;
using System.Collections;

public class WordButton {

	public string buttonLabel;
	public float buttonPosX, buttonPosY, topLeftX, topLeftY, buttonWidth;
	public bool toggle = true;

	//Constructor
	public WordButton (int index, string word) //takes a list of strings and converts each string into a button WordButton object suitable for deployment into OnGUI
	{
		buttonLabel = word;
		buttonWidth = buttonLabel.Length * 15;
		buttonPosX = (index % 4) * (Screen.width / 10);
		buttonPosY = (2 * Screen.height / 3) + ((Mathf.FloorToInt(index / 4)) * 50);
	}

}
