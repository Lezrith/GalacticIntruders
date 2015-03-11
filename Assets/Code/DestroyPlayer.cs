using UnityEngine;
using System.Collections;

public class DestroyPlayer : MonoBehaviour {

	private GameObject playerShipObject;

	private Shield shieldScript;
	private ScoreControl scoreControl;

	private bool shieldState;
	private int enemyScoreValue;

	public int scoreValue;
	public AudioClip explosionPlayer;
	public AudioClip explosionEnemy;
	
	void Start()
	{
		playerShipObject = GameObject.FindWithTag ("PlayerShip");
		if ( playerShipObject != null) 
		{
			shieldScript = playerShipObject.GetComponent<Shield>();
		} 
		else 
		{
			Debug.Log("Cannot find Shield script");
		}

		GameObject scoreControlObject = GameObject.FindWithTag ("ScoreControl");
		if (scoreControlObject != null) 
		{
			scoreControl = scoreControlObject.GetComponent <ScoreControl> ();
		} 
		else 
		{
			Debug.Log("Cannot find ScoreControl script");
		}
		
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (tag == "EnemyShip" && other.tag == "PlayerShip") 
		{
			shieldScript=other.gameObject.GetComponent<Shield>();
			shieldState=shieldScript.shieldState;

			if (!shieldState) 
			{
				AudioSource.PlayClipAtPoint(explosionPlayer,other.transform.position,0.2f);
				Destroy (other);
				//Application.LoadLevel("GameOver");
				GameObject gameOverObject = GameObject.FindWithTag ("ScoreControl");
				GoToGameOver gameOver = gameOverObject.GetComponent<GoToGameOver> ();
				gameOver.GameOver ();
			} 

			else if (shieldState) 
			{
				AudioSource.PlayClipAtPoint(explosionEnemy,other.transform.position,0.2f);
				enemyScoreValue=this.gameObject.GetComponent<DestroyPlayer>().scoreValue;
				scoreControl.AddScore (enemyScoreValue);
				TrashMan.despawn (this.gameObject);
			}
		}
	}
}
