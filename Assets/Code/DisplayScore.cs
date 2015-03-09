using UnityEngine.UI;
using System.Collections;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    Text[] score;
    // Use this for initialization
    public void Start()
    {
        score = new Text[5];
        score[0] = GameObject.Find("High Scores/Scores/Score1/Text").GetComponent<Text>();
        score[1] = GameObject.Find("High Scores/Scores/Score2/Text").GetComponent<Text>();
        score[2] = GameObject.Find("High Scores/Scores/Score3/Text").GetComponent<Text>();
        score[3] = GameObject.Find("High Scores/Scores/Score4/Text").GetComponent<Text>();
        score[4] = GameObject.Find("High Scores/Scores/Score5/Text").GetComponent<Text>();
        score[0].text = PlayerPrefs.GetInt("Wynik1").ToString();
        score[1].text = PlayerPrefs.GetInt("Wynik2").ToString();
        score[2].text = PlayerPrefs.GetInt("Wynik3").ToString();
        score[3].text = PlayerPrefs.GetInt("Wynik4").ToString();
        score[4].text = PlayerPrefs.GetInt("Wynik5").ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
