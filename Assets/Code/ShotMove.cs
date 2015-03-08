using UnityEngine;
using System.Collections;

public class ShotMove : MonoBehaviour {

	public float Speed;
    private float Screenx=Screen.width;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().AddForce (new Vector2 (Speed, 0));
	
	}
	
	// Update is called once per frame
    void FixedUpdate()
    {
        Vector3 ShotPos = Camera.main.WorldToScreenPoint(transform.position);
        if (ShotPos.x > Screenx) Destroy(gameObject);
    }
}
