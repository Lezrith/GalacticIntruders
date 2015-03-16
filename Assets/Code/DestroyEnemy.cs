using UnityEngine;
using System.Collections;

public class DestroyEnemy : MonoBehaviour {

	private DestroyPlayer enemyScript;
	private ScoreControl scoreControl;
	private GoToGameOver gameOver;
	private AudioClip enemyDespawnSound;

	private bool shieldState;
	private int enemyScoreValue;
	private float enemyExplosionRadius;




	void OnEnable()
	{
		/*GameObject scoreControlObject = GameObject.FindWithTag ("ScoreControl");
		if (scoreControlObject != null) 
		{
			scoreControl = scoreControlObject.GetComponent <ScoreControl> ();
		} 
		else 
		{
			Debug.Log("Cannot find ScoreControl script");
		}*/
		scoreControl = HGetComponentGeneric.ByTag<ScoreControl> ("ScoreControl");
	}
	void OnTriggerEnter2D(Collider2D other) 
	{			
		if (other.tag == "EnemyShip"||other.tag == "Asteroid") 
		{
			enemyScript=other.gameObject.GetComponent<DestroyPlayer>();
			enemyScoreValue=enemyScript.scoreValue;
			enemyDespawnSound=enemyScript.despawnSound;
			enemyExplosionRadius=enemyScript.explosionRadius;

			if(enemyDespawnSound!=null)
			{
				AudioSource.PlayClipAtPoint(enemyDespawnSound,other.transform.position,0.2f);
			}
			scoreControl.AddScore(enemyScoreValue);

			TrashMan.despawn (other.gameObject);

			Collider2D[] colliders = Physics2D.OverlapCircleAll(other.gameObject.transform.position, enemyExplosionRadius);

				foreach(var col in colliders)
				{
					if (col.tag == "Shot")
					{
						TrashMan.despawn(col.gameObject);
					}
				}
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

