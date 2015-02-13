using UnityEngine;
using System.Collections;

public class ScoreControl : MonoBehaviour {

	public int score;
	private GUIText ScoreGUIText;



	void UpdateScore () 
	{
		ScoreGUIText.text = "Score: " + score;
	}

	void Awake () 
	{
		ScoreGUIText = GameObject.FindWithTag("Wynik").guiText;
		score = 0;
		UpdateScore ();
	}

	public void AddScore(int newScore)
	{
		score += newScore;
		UpdateScore ();
	}


}
