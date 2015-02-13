using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour {
    public float Speed;
    
	// Use this for initialization
	void Start () {
		this.transform.position = Camera.main.ViewportToWorldPoint (new Vector3 (0.05f, 0.5f, 0));
	
	}
	
	// Update is called once per frame
	void Update () 
	{
        if (Input.GetKeyDown("escape"))
            Application.Quit();
        float MoveY = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
		transform.position = new Vector2 (transform.position.x, Mathf.Clamp (transform.position.y + MoveY, -1.83f, 1.83f));
	}
}
