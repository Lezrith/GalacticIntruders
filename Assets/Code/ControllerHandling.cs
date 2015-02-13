using UnityEngine;
using System.Collections;

public class ControllerHandling : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") && !Input.GetMouseButtonDown(0))
			Application.LoadLevel ("Doboa");
		if (Input.GetButtonDown ("Fire2"))
			Application.LoadLevel ("Menu");
	
	}
}
