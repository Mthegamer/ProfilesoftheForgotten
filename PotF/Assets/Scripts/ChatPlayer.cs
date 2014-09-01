using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChatPlayer : MonoBehaviour { //handles timer and delays + progress through texts
	int progressCounter = 0;
	DialogueDisplayer dialogueDisplayer;


	// Use this for initialization
	void Start () {
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
		jasonCycle ();
	}
	

	IEnumerator jasonDelay()
	{
		yield return new WaitForSeconds (2);
		progressCounter++;
	}
	
	// Update is called once per frame
	void Update () 
	{

	}
}
