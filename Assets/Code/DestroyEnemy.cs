using UnityEngine;
using System.Collections;

public class DestroyEnemy : MonoBehaviour {

	private GameObject scoreControlObject;
	private GameObject gameOverObject;
	public AudioClip explosionEnemy;

	private ScoreControl scoreControl;
	private GoToGameOver gameOver;

	private bool shieldState;
	private int enemyScoreValue;

	public float ExplosionRadius;



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
	}
	void OnTriggerEnter2D(Collider2D other) 
	{			
		if (other.tag == "EnemyShip") 
		{
		
			AudioSource.PlayClipAtPoint(explosionEnemy,other.transform.position,0.2f);

			enemyScoreValue=other.gameObject.GetComponent<DestroyPlayer>().scoreValue;
			scoreControl.AddScore (enemyScoreValue);
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

