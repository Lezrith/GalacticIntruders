using UnityEngine;
using System.Collections;

public class MenuToGameOnClick : MonoBehaviour {
	
	void Start () 
	{
	
	}

	void Update () 
	{
		if (Input.GetButtonDown ("Fire1"))
						Application.LoadLevel ("Doboa");
        if (Input.GetKeyDown("escape"))
            Application.Quit();
	}
}
