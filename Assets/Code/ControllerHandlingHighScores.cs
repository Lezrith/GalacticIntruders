using UnityEngine;
using System.Collections;

public class ControllerHandlingHighScores : MonoBehaviour {

	ClearStatistics clearStatisticsButton;

	void Start ()
	{
		clearStatisticsButton = (ClearStatistics)this.GetComponent (typeof(ClearStatistics));
	}

	void Update () 
	{
		if (Input.GetKeyDown ("joystick button 1"))
			Application.LoadLevel ("Menu");
		if (Input.GetKeyDown ("joystick button 2"))
			clearStatisticsButton.Clear();

	}
}
