using UnityEngine;
using System.Collections;

public class ExplosionDispose : MonoBehaviour {
    private float timeBegin;
	// Use this for initialization
	void Start () {
        timeBegin = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time - timeBegin > 4.0f) TrashMan.despawn(this.gameObject);
	}
}
