using UnityEngine;
using System.Collections;

public class SpawnEnemies : MonoBehaviour {
    public  GameObject[] enemies;
    public float spawnTime = 3f;
    public float spawnDelay = 0.6f;
	private float timer;
	
	void Start () 
	{
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
		timer = Time.time;
	}
    void Spawn()
    {
        int enemyIndex = Random.Range(0, enemies.Length);
       // Instantiate(enemies[enemyIndex], new Vector2(transform.position.x, Random.Range(-1790f / 1000, 1790f / 1000)), transform.rotation);
       TrashMan.spawn(enemies[enemyIndex], new Vector2(transform.position.x,Random.Range(-1790f/1000,1790f/1000)) , transform.rotation);
       if (Time.time - timer > 6.0f)
       {
           spawnTime = 0.5f;
           CancelInvoke();
           Start();
       }
    }
}
