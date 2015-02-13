using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour {

	private float shieldOnTime=0.0f;
	public bool shieldState=false;
	private int shieldCount=1;
	
	void Update () {
		if ( (Input.GetKeyDown ("e")) && (!shieldState) && (shieldCount>0) ) {
			shieldOnTime = Time.time;
			shieldState = true;
			shieldCount--;
			Debug.Log ("ShieldON");
		}
		if (shieldState&&Time.time - shieldOnTime > 3.0f) {
			shieldState = false;
			Debug.Log ("ShieldOFF");
		}

	}
}
