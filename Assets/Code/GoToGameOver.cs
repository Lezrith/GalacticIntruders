using UnityEngine;
using System.Collections;

public class GoToGameOver : MonoBehaviour {

	private ScoreControl scoreSave;
	private GameObject scoreSaveObject;
	private int scoreToTake;
	static bool ifSuccess;
	int[] tab;

	private bool ifHighscore(int Save)
	{
		if (Save > PlayerPrefs.GetInt("Wynik5"))
			return true;
		else 
			return false;
	}

	static void Swap(int[] numbers, int firstIndex, int secondIndex)
	{
		int temp = numbers[firstIndex];
		numbers[firstIndex] = numbers[secondIndex];
		numbers[secondIndex] = temp;
	}

	static void Sort(int[] numbers)
	{
		for (int lastIndex = numbers.Length - 1; lastIndex > 0; lastIndex--)
		{
			for (int currentIndex = 0; currentIndex < lastIndex; currentIndex++)
			{
				if (numbers[currentIndex] > numbers[currentIndex + 1])
				{
					Swap(numbers, currentIndex, currentIndex + 1);
				}
			}
		}
	}


	public void GameOver()
	{
		GameObject scoreSaveObject = GameObject.FindWithTag ("ScoreControl");
		ScoreControl scoreSave = scoreSaveObject.GetComponent<ScoreControl> ();

		scoreToTake= scoreSave.score;
		ifSuccess = ifHighscore(scoreToTake);
		Debug.Log(ifSuccess);
		if(ifSuccess)
		{
		tab=new int[6];
		tab[0]=PlayerPrefs.GetInt("Wynik1");
		tab[1]=PlayerPrefs.GetInt("Wynik2");
		tab[2]=PlayerPrefs.GetInt("Wynik3");
		tab[3]=PlayerPrefs.GetInt("Wynik4");
		tab[4]=PlayerPrefs.GetInt("Wynik5");
		tab[5]=scoreToTake;
		Sort(tab);
			Swap (tab,0,5);
			Swap (tab,1,4);
			Swap (tab,2,3);
		for(int i=0;i<5;i++)
			Debug.Log(tab[i]);
			PlayerPrefs.SetInt("Wynik1",tab[0]);
			PlayerPrefs.SetInt("Wynik2",tab[1]);
			PlayerPrefs.SetInt("Wynik3",tab[2]);
			PlayerPrefs.SetInt("Wynik4",tab[3]);
			PlayerPrefs.SetInt("Wynik5",tab[4]);
		}
		Application.LoadLevel("GameOver");
	}
}
