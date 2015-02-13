using UnityEngine;
using System.Collections;

public class BackgroundMove : MonoBehaviour {

	public float speed;
	public Transform DespawnPoint;
	public Transform SpawnPoint;
	
	void Start () {
	
	}

	void FixedUpdate () 
	{
		this.transform.position=(new Vector2(this.transform.position.x-speed*Time.deltaTime,transform.position.y));

		if (this.transform.position.x < DespawnPoint.position.x)
						this.transform.position = SpawnPoint.position;
	
	}
}
