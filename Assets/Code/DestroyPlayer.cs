using UnityEngine;
using System.Collections;

public class DestroyPlayer : MonoBehaviour {

	private GameObject playerShipObject;
	private Shield shieldScript;
	private ScoreControl scoreControl;
	private GoToGameOver gameOver;

	private bool shieldState;
	private int enemyScoreValue;
	
	public AudioClip despawnSound;
	public int scoreValue;
	public float explosionRadius;
	
	void OnEnable()
	{
		/*playerShipObject = GameObject.FindWithTag ("PlayerShip");
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
		*/
		shieldScript = HGetComponentGeneric.ByTag<Shield> ("PlayerShip");
		scoreControl = HGetComponentGeneric.ByTag<ScoreControl> ("ScoreControl");
		gameOver = HGetComponentGeneric.ByTag<GoToGameOver>("ScoreControl");
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "PlayerShip") 
		{
			shieldState=shieldScript.shieldState;

			if (!shieldState) 
			{
				AudioSource.PlayClipAtPoint(shieldScript.playerDeathSound, other.gameObject.transform.position, 0.2f);
				Destroy (other);
				//Application.LoadLevel("GameOver");
				//GameObject gameOverObject = GameObject.FindWithTag ("ScoreControl");
				//GoToGameOver gameOver = gameOverObject.GetComponent<GoToGameOver> ();
				gameOver.GameOver ();
			} 

			else if (shieldState) 
			{
				if(despawnSound!=null)
				{
				AudioSource.PlayClipAtPoint(despawnSound, this.gameObject.transform.position, 0.2f);
				}

				enemyScoreValue=this.gameObject.GetComponent<DestroyPlayer>().scoreValue;
				scoreControl.AddScore (enemyScoreValue);

				TrashMan.despawn (this.gameObject);
			}
		}
	}
}
