using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ButtonLayout : MonoBehaviour {

	public List<GameObject> ButtonList;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void DeactivateAll() {
		foreach (GameObject button in ButtonList)
			button.SetActive (false);
	}
}
