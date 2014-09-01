using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class DialogueElement
{
	public enum Characters{Stepsister, Pink};
	public Characters Character;
	public List<string> wordChoices;
	public string DialogueText;
	public GUIStyle DialogueTextStyle;
	public float TextPlayBackSpeed;
	public AudioClip PlayBackSoundFile;
}
