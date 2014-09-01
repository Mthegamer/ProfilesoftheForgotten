using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DialogueDisplayer : MonoBehaviour {
	public GUIText sentence;
	GUIStyle style = new GUIStyle();
	List<string> dialogueTexts = new List<string>();
	
	public void displayJasonText(string userInput)
	{
	 //ideal color codes are 6FFF47, CB2EFF, FF69F5
		addToDialogue ("<color=#6FFF47> Jason: </color>" + userInput);
	}

	public void displaySisterText(string sisterInput)
	{
		print ("add to dialogue");
		addToDialogue ( "<color=#CB2EFF> Stepsister: </color>" + sisterInput);
	}

	void addToDialogue(string sentenceText)
	{


		if (dialogueTexts.Count < 6)
		{
			print ("count < 6");
			dialogueTexts.Add(sentenceText); //adds new dialogue to chat area while it still isnt full
			print (dialogueTexts[0]);
		}
		
		else

		{
			for (int i = 1; i < 6; i++)
			{
				dialogueTexts[i-1] = dialogueTexts[i];
			}
			dialogueTexts[5] = sentenceText; //moves all text one slide down when it is full
		}
	}

	void Update()
	{
		if (dialogueTexts.Count > 0)
		{
				
			for (int i = 1; i < dialogueTexts.Count+1; i++)
			{
				GameObject temp = GameObject.Find("Sent"+i);
				temp.guiText.text = dialogueTexts[i-1];
				temp.transform.position = new Vector3 (0.1f, (1.0f - (float)i * 0.1f),0.0f);
			}
		}	
	}
	// Use this for initialization
	void Start ()
	{
		style.richText = true;
	}

}
