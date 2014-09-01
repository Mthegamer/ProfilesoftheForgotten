using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DialogueData : MonoBehaviour {

	List<string> a1 = new List<string> {"when can I see you? ", "can I see you? "};
	List<string> a2 = new List<string> {"hey where are you?"};
	List<string> a3 = new List<string> {"ok see you later"};
	List<string> s1 = new List<string> {"when","can","I","see","you?"};
	List<string> s2 = new List<string> {"hey", "where", "are","you?"};
	List<string> s3 = new List<string> {"ok", "see", "you","later"};
	List<string> a4 = new List<string> {"when can I see you? ", "can I see you? "};
	List<string> a5 = new List<string> {"hey where are you? "};
	List<string> a6 = new List<string> {"ok see you later "};
	List<string> s4 = new List<string> {"when","can","I","see","you?"};
	List<string> s5 = new List<string> {"hey", "where", "are","you?"};
	List<string> s6 = new List<string> {"ok", "see", "you","later"};
	string m1 = ("Jason is that you");
	string m2 = ("Oh come see me please :(");
	string m3 = ("meet me at our special place.");
	string m4 = ("meet me at our special place.");
	string m5 = ("meet me at our fun place.");
	string m6 = ("meet me at our cool place.");

	List<WordBank> wordBankList = new List<WordBank>();
	List<string> stepsisterSentences = new List<string>();
	WordBank temp;

	public List<WordBank> returnWordBankList()
	{
		return wordBankList;
	}

	public List<string> returnStepsisterSentences()
	{
		return stepsisterSentences;
	}

	void Start()
	{
		temp = gameObject.GetComponent<WordBank> ();

		temp.setWordBank((s1),(a1));
		wordBankList.Add(temp);
		stepsisterSentences.Add(m1);
		temp.setWordBank((s2),(a2));
		wordBankList.Add(temp);
		stepsisterSentences.Add(m2);
		temp.setWordBank((s3),(a3));
		wordBankList.Add(temp);
		stepsisterSentences.Add(m3);
		temp.setWordBank((s4),(a4));
		wordBankList.Add(temp);
		stepsisterSentences.Add(m4);
		temp.setWordBank((s5),(a5));
		wordBankList.Add(temp);
		stepsisterSentences.Add(m5);
		temp.setWordBank((s6),(a6));
		wordBankList.Add(temp);
		stepsisterSentences.Add(m6);
	}

}
