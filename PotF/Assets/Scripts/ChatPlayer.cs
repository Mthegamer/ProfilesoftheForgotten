using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChatPlayer : MonoBehaviour { //handles timer and delays + progress through texts

	public Dialogue dialogueFile;
	int progressCounter = 0;
	public int delayRangeMin, delayRangeMax, userResponseDelay;
	DialogueDisplayer dialogueDisplayer;


	//this should be rewritten such that there is more flexibility in terms of progress

	void Start () {
		StepsisterCycle ();
		dialogueDisplayer = gameObject.GetComponent<DialogueDisplayer> ();
	}

	void StepThroughDialogue()
	{
		switch (dialogueFile.DialogItems[progressCounter].character)
		{
			case Characters.Pink : StartCoroutine ("sisterDelay"); break;
			case Characters.Stepsister : StartCoroutine ("sisterDelay"); break;
			case Characters.User : StartCoroutine ("userDelay"); break;
		}
	}

	void StepsisterCycle() //sets the chat in motion
	{
		StartCoroutine ("sisterDelay");
	}

	void userCycle()
	{
		StartCoroutine ("userDelay");
	}

	IEnumerator sisterDelay()
	{

		int delayInt = Random.Range (delayRangeMin, delayRangeMax);
		yield return new WaitForSeconds (delayInt);
		userCycle ();
	}
	

	IEnumerator userDelay()
	{
		yield return new WaitForSeconds (userResponseDelay);
		progressCounter++;
	}
	
	public int returnProgCounter()
	{
		return progressCounter;
	}
}
