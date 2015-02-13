using UnityEngine;
using System.Collections;

public class EnemyShipMovingLeft : MonoBehaviour {
    
    public float Speed;
	private GoToGameOver gameOver;
	private GameObject gameOverObject;
    	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        transform.position = new Vector2(transform.position.x - Speed * Time.deltaTime, transform.position.y);
        if (screenPos.x < 5) {             
			GameObject gameOverObject = GameObject.FindWithTag("ScoreControl");
			GoToGameOver gameOver =  gameOverObject.GetComponent<GoToGameOver>();
			gameOver.GameOver();
            
        }
                    
	}
}
