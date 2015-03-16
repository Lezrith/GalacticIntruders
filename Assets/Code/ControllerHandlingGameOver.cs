using UnityEngine;
using System.Collections;

public class ControllerHandlingGameOver : MonoBehaviour {

	void Update () {
		if (Input.GetKeyDown("joystick button 0"))
			Application.LoadLevel ("Doboa");
		if (Input.GetKeyDown ("joystick button 1"))
			Application.LoadLevel ("Menu");
		if (Input.GetKeyDown("joystick button 3"))
			Application.LoadLevel ("HighScores");
		
	}
}
