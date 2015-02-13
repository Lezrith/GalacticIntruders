using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {
	

	
    void Awake(){
		if (GameObject.FindGameObjectsWithTag ("Wynik").Length > 1)
			Destroy (this.gameObject);
			DontDestroyOnLoad(gameObject);
    }
}
