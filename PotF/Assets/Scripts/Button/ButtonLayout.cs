using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ButtonLayout : MonoBehaviour {

	public string buttonLabel;
	public List<GameObject> ButtonList;
	public float buttonVerticalDistance, buttonHorizontalDistance;
	float topLeftX, topLeftY;

	// Use this for initialization
	void Awake () {
		topLeftX = ButtonList [0].GetComponent<RectTransform> ().anchoredPosition.x; //sets up the button layout with respect to first button
		topLeftY = ButtonList [0].GetComponent<RectTransform> ().anchoredPosition.y; //in list
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Activate(List<string> wordChoices) {
		for (int i = 0; i < wordChoices.Count; i++) {
			ButtonList[i].GetComponent<RectTransform> ().anchoredPosition.x = topLeftX + (i % 4) * (buttonHorizontalDistance); //sets x pos


			ButtonList[i].GetComponent<RectTransform> ().anchoredPosition.y =												   //sets y pos
				topLeftY + ((Mathf.FloorToInt(i / 4)) * buttonVerticalDistance);


		}
	}

	public void DeactivateAll() {
		foreach (GameObject button in ButtonList)
			button.SetActive (false);
	}



	//Constructor
	void setButton (int index, string word) //takes a list of strings and converts each string into a button WordButton object suitable for deployment into OnGUI
	{
	}

}
