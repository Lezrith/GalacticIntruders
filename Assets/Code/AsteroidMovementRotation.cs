using UnityEngine;
using System.Collections;

public class AsteroidMovementRotation : MonoBehaviour {

    public float tiltAngle;
    float speedX;
    float speedY;
    
    void Start()
    {
        speedX = Random.value*3.0f+1.0f;
        speedY = speedX / 3;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, Time.deltaTime * tiltAngle);
        transform.position = new Vector2(transform.position.x - speedX * Time.deltaTime, transform.position.y-speedY * Time.deltaTime);
    }
}
