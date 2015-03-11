using UnityEngine;
using System.Collections;

public class ShotMove : MonoBehaviour {

	public float Speed;
    private float Screenx = Screen.width;
	void Start () {
		this.gameObject.GetComponent<Rigidbody2D>().AddForce (new Vector2 (Speed, 0));
	
	}

    void FixedUpdate()
    {
        Vector3 ShotPos = Camera.main.WorldToScreenPoint(transform.position);
        if (ShotPos.x > Screenx) TrashMan.despawn(this.gameObject);
    }
}
