using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	public GameObject Shot;
	public Transform ShotSpawn;
	public Transform ShotSpawn2;
	public AudioClip fireSound;
	public float fireRate;
	
	private float nextFire;
	private int shotIndex;

	void Update ()
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;

			TrashMan.spawn(Shot, new Vector2(ShotSpawn.position.x, ShotSpawn.position.y), transform.rotation);
			TrashMan.spawn(Shot, new Vector2(ShotSpawn2.position.x, ShotSpawn2.position.y), transform.rotation);

			AudioSource.PlayClipAtPoint (fireSound, this.gameObject.transform.position);
		}
	}
}
