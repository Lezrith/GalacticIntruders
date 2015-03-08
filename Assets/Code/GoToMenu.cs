using UnityEngine;
using System.Collections;

public class GoToMenu : MonoBehaviour {

    private GameObject wyn;
	void OnMouseDown() {
        wyn = GameObject.FindWithTag("Wynik");
		wyn.GetComponent<GUIText>().enabled = false;
        Application.LoadLevel("Menu");
	
	}
}
