using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public GameObject Shot;
	public Transform ShotSpawn;
	public Transform ShotSpawn2;
	public float fireRate;
	
	private float nextFire;
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(Shot, ShotSpawn.position, ShotSpawn.rotation);
			Instantiate(Shot, ShotSpawn2.position, ShotSpawn2.rotation);
			this.GetComponent<AudioSource>().Play ();
					}
	}
}
