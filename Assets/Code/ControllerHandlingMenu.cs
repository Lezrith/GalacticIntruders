using UnityEngine;
using System.Collections;

public class ControllerHandlingMenu : MonoBehaviour {

	private GameObject music;


	void Update () {
		if (Input.GetKeyDown ("joystick button 0")) 
		{
			music = GameObject.Find ("Music");
			Destroy (music);
			Application.LoadLevel ("Doboa");
		}
		if (Input.GetKeyDown ("joystick button 1"))
			Application.Quit ();
		if (Input.GetKeyDown("joystick button 3"))
			Application.LoadLevel ("HighScores");
	
	}
}
