using UnityEngine;
using System.Collections;

public class DestroyEnemy : MonoBehaviour {
    public float ExplosionRadius;
	private ScoreControl scoreControl;
	private DestroyEnemy doc;
	public int scoreValue;
	private bool shieldState;
	private GameObject scoreControlObject;
	private GameObject docObject;
	private GameObject playerShipObject;
	private Shield shieldScript;
	public AudioClip explosionEnemy;
	private GoToGameOver gameOver;
	private GameObject gameOverObject;


	void Start()
	{
		GameObject scoreControlObject = GameObject.FindWithTag ("ScoreControl");
		if (scoreControlObject != null) 
		{
			scoreControl = scoreControlObject.GetComponent <ScoreControl> ();
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
	void OnTriggerEnter2D(Collider2D other) 
	{
		GameObject scoreControlObject = GameObject.FindWithTag("ScoreControl");
		scoreControl = scoreControlObject.GetComponent<ScoreControl>();
		shieldState = shieldScript.shieldState;			
		if (other.tag == "EnemyShip") 
		{
		AudioSource.PlayClipAtPoint(explosionEnemy,other.transform.position,0.2f);
		other.gameObject.audio.Play();
		docObject=other.gameObject;
		doc = docObject.GetComponent <DestroyEnemy>();
		scoreControl.AddScore (doc.scoreValue);
		
		TrashMan.despawn (other.gameObject);
		Collider2D[] colliders = Physics2D.OverlapCircleAll(other.gameObject.transform.position, ExplosionRadius);
			foreach(var col in colliders)
			{
				if (col.tag == "Shot")
				{
					TrashMan.despawn(col.gameObject);
				}
			}
			}
         if ( tag == "EnemyShip" && other.tag == "PlayerShip")
        {
			if (!shieldState)
			{
			Destroy(other);
			//Application.LoadLevel("GameOver");
			GameObject gameOverObject = GameObject.FindWithTag("ScoreControl");
			GoToGameOver gameOver =  gameOverObject.GetComponent<GoToGameOver>();
			gameOver.GameOver();
			}
			else if (shieldState)
			{
				docObject=gameObject;
				doc = docObject.GetComponent <DestroyEnemy>();
				scoreControl.AddScore (doc.scoreValue);
				TrashMan.despawn (this.gameObject);
			}

			/*GameObject scoreSaveObject = GameObject.FindWithTag ("ScoreControl");
			ScoreControl scoreSave = scoreSaveObject.GetComponent<ScoreControl> ();
			scoreToTake= scoreSave.score;
			Debug.Log(scoreToTake);
			ifSuccess = ifHighscore(scoreToTake);
			Debug.Log(ifSuccess);
			//if(ifSuccess)
			//{
				tab=new int[6];
				tab[0]=PlayerPrefs.GetInt("Wynik1");
				tab[1]=PlayerPrefs.GetInt("Wynik2");
				tab[2]=PlayerPrefs.GetInt("Wynik3");
				//tab[3]=PlayerPrefs.GetInt("Wynik4");
				tab[4]=PlayerPrefs.GetInt("Wynik5");
				tab[3]=scoreToTake;
				Sort(tab,0,5);
			for(int i=0;i<5;i++)
				Debug.Log(tab[i]);
			//}
			Application.LoadLevel("GameOver");
			*/

         }
         
		}
	
	}

