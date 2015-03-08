using UnityEngine;
using System.Collections;

public class ControllerHandlingMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("joystick button 0"))
			Application.LoadLevel ("Doboa");
		if (Input.GetKeyDown ("joystick button 1"))
			Application.Quit ();
		if (Input.GetKeyDown("joystick button 3"))
			Application.LoadLevel ("HighScores");
	
	}
}
