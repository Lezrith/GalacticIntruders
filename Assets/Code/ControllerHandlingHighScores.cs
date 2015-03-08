using UnityEngine;
using System.Collections;

public class ControllerHandlingHighScores : MonoBehaviour {

	ClearStatistics baton;

	// Use this for initialization
	void Start () {
		baton = (ClearStatistics)this.GetComponent(typeof(ClearStatistics));
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("joystick button 1"))
			Application.LoadLevel ("Menu");
		if (Input.GetKeyDown ("joystick button 2")) {
			baton.Clear();
		}

	}
}
