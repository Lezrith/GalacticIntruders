using UnityEngine;
using System.Collections;

public class MenuOnClick : MonoBehaviour
{
    private GameObject wyn;

    void Start()
    {
        wyn = GameObject.FindWithTag("Wynik");
    }
    public void GoToDoboa()
    {
        wyn.guiText.enabled = true;
        Application.LoadLevel("Doboa");
    }

    public void GoToHighScores()
    {
        wyn.guiText.enabled = false;
        Application.LoadLevel("HighScores");
    }
    public void GoToMenu()
    {
        wyn.guiText.enabled = false;
        Application.LoadLevel("Menu");
    }
    public void Exit()
    {
        Application.Quit();
    }
 
}
