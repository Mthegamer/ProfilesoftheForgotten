using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChatPlayer : MonoBehaviour { //handles timer and delays + progress through texts
	GUIDisplayer guiDisplayer;
	int progressCounter = 0;
	DialogueDisplayer dialogueDisplayer;
	DialogueData data;
	

	// Use this for initialization
	void Start () {
		guiDisplayer = gameObject.GetComponent<GUIDisplayer> ();
		data = gameObject.GetComponent<DialogueData> ();
		stepsisterCycle ();
		dialogueDisplayer = gameObject.GetComponent<DialogueDisplayer> ();
	}

	void stepsisterCycle() //sets the chat in motion
	{
		StartCoroutine ("sisterDelay");
	}

	public int returnProgCounter()
	{
		return progressCounter;
	}

	void jasonCycle()
	{
		StartCoroutine ("jasonDelay");
	}

	IEnumerator sisterDelay()
	{

		int delayInt = Random.Range (3, 5);
		yield return new WaitForSeconds (delayInt);
		dialogueDisplayer.displaySisterText(data.returnStepsisterSentences()[progressCounter]);
		jasonCycle ();
	}
	

	IEnumerator jasonDelay()
	{
		yield return new WaitForSeconds (2);
		guiDisplayer.setButtonList(data.returnWordBankList()[progressCounter]);
		guiDisplayer.toggleOnOff ();
		progressCounter++;
	}
	
	// Update is called once per frame
	void Update () 
	{

	}
}
