using UnityEngine;
using System.Collections;

public class GoToDoboa : MonoBehaviour
{
    private GameObject wyn;

    void OnMouseDown(){
		wyn = GameObject.FindWithTag("Wynik");
		wyn.GetComponent<GUIText>().enabled = true;
        Application.LoadLevel("Doboa");
        
    }
}
