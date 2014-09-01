using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WordBank : MonoBehaviour { //holds data to be stored in a 

	List<WordButton> buttons = new List<WordButton>();
	List<string> answers = new List<string>();
	// Use this for initialization
	public void setWordBank(List<string> buttonLabels, List<string> possibleAnswers)
	{
		for (int i = 0; i < buttonLabels.Count; i++)
		{
			WordButton tempButton = new WordButton(i, buttonLabels[i]);
			buttons.Add(tempButton);
			answers = possibleAnswers;
		}
	}

	public bool isProperSentence(string userAnswer)
	{
		for (int i = 0; i < answers.Count; i++)
		{
			if (answers[i] == userAnswer)
			{
				return true;
			}
		}
		return false;
	}

	public List<WordButton> returnWordButtons()
	{
		return buttons;
	}

}
