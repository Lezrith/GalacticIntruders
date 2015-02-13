using UnityEngine.UI;
using System.Collections;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    Text[] score;
    // Use this for initialization
    void Start()
    {
        score = new Text[5];
        score[0] = GameObject.Find("Canvas/Text0").GetComponent<Text>();
        score[1] = GameObject.Find("Canvas/Text1").GetComponent<Text>();
        score[2] = GameObject.Find("Canvas/Text2").GetComponent<Text>();
        score[3] = GameObject.Find("Canvas/Text3").GetComponent<Text>();
        score[4] = GameObject.Find("Canvas/Text4").GetComponent<Text>();
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
