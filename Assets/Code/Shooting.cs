using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	void Start () {
	
	}

	public GameObject Shot;
	public GameObject[] shots;
	public Transform ShotSpawn;
	public Transform ShotSpawn2;
	public float fireRate;
	
	private float nextFire;
	private int shotIndex;

	void Update ()
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			shotIndex = Random.Range(0, shots.Length);
			TrashMan.spawn(shots[shotIndex], new Vector2(ShotSpawn.position.x, ShotSpawn.position.y), transform.rotation);

			shotIndex = Random.Range(0, shots.Length);
			TrashMan.spawn(shots[shotIndex], new Vector2(ShotSpawn2.position.x, ShotSpawn2.position.y), transform.rotation);

			this.GetComponent<AudioSource>().Play ();
		}
	}
}
