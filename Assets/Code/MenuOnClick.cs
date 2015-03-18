using UnityEngine;
using System.Collections;

public class MenuOnClick : MonoBehaviour
{
    private GameObject wyn;
	private GameObject music;
    void Start()
    {
        wyn = GameObject.FindWithTag("Wynik");
    }
    public void GoToDoboa()
    {
        wyn.GetComponent<GUIText>().enabled = true;
		music = GameObject.Find ("Music");
		Destroy (music);
        Application.LoadLevel("Doboa");
    }

    public void GoToHighScores()
    {
        wyn.GetComponent<GUIText>().enabled = false;
        Application.LoadLevel("HighScores");
    }
    public void GoToMenu()
    {
        wyn.GetComponent<GUIText>().enabled = false;
        Application.LoadLevel("Menu");
    }
    public void Exit()
    {
        Application.Quit();
    }
 
}
