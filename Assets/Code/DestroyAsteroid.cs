using UnityEngine;
using System.Collections;

public class DestroyAsteroid : MonoBehaviour
{
    private ScoreControl scoreControl;
	private GoToGameOver gameOver;
	private GameObject gameOverObject;
	private bool shieldState;
	private Shield shieldScript;
	private GameObject playerShipObject;

    void Start()
    {
        GameObject scoreControlObject = GameObject.FindWithTag("ScoreControl");
        if (scoreControlObject != null)
        {
            scoreControl = scoreControlObject.GetComponent<ScoreControl>();
        }
        else
        {
            Debug.Log("Cannot find ScoreControl script");
        }

		playerShipObject = GameObject.FindWithTag ("PlayerShip");
		if ( playerShipObject != null) 
		{
			shieldScript = playerShipObject.GetComponent<Shield>();
		} 
		else 
		{
			Debug.Log("Cannot find Shield script");
		}
    }

    void Update()
    {
        if (transform.position.x < -4.0f || transform.position.y<-3.0f) TrashMan.despawn(gameObject);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
		GameObject scoreControlObject = GameObject.FindWithTag("ScoreControl");
		scoreControl = scoreControlObject.GetComponent<ScoreControl>();
		shieldState = shieldScript.shieldState;
        if (col.tag == "Shot")
        {
            scoreControl.AddScore(50);
			TrashMan.despawn(gameObject);
        }
        else if (col.tag == "PlayerShip")
        {
			if(!shieldState)
			{
			GameObject gameOverObject = GameObject.FindWithTag("ScoreControl");
			GoToGameOver gameOver =  gameOverObject.GetComponent<GoToGameOver>();
			gameOver.GameOver();
			}
			else if (shieldState)
			{
				scoreControl.AddScore(50);
				TrashMan.despawn (this.gameObject);
			}
        }
        
    }
}
