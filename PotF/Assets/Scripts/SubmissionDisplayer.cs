using UnityEngine;
using System.Collections;

public class SubmissionDisplayer : MonoBehaviour {


	string submittedWords = "";

	public void addWord(string word)
	{
		submittedWords += word + " ";
	}

	public void reset()
	{
		submittedWords = "";
	}

	public string returnSubmittedWords()
	{
		return submittedWords;
	}
	
	// Update is called once per frame
	void Update () {
		GameObject bar = GameObject.Find ("submissionBar");
		bar.guiText.text = submittedWords;
	}
}
