using UnityEngine;
using System.Collections;

public class GoToDoboa : MonoBehaviour
{
    private GameObject wyn;

    void OnMouseDown(){
		wyn = GameObject.FindWithTag("Wynik");
		wyn.guiText.enabled = true;
        Application.LoadLevel("Doboa");
        
    }
}
