using UnityEngine;
using System.Collections;

public class SpawnAsteroid : MonoBehaviour
{
    public GameObject[] asteroids;
    public float spawnTime;
    public float spawnDelay;
    private float timeOffAsteroidBelt;
    private float timeIfAsteroidBelt;
    public bool asteroidBelt;
    private SpriteRenderer danger;
    public float FlashTime;
	private bool ifAsteroidBelt;
	private float probability;
	private float delayTime;
    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
        timeOffAsteroidBelt= Time.time;
        danger = GameObject.Find("DangerAsteroidBelt").GetComponent<SpriteRenderer>();      
    }
    void Flash()
    {
        if (danger.enabled)
            danger.enabled = false;
        else
            danger.enabled = true;
        if (Time.time - timeOffAsteroidBelt > 2.0f)
        {
            danger.enabled = false;
        }
    }
	void Spawn() 
	{
		if (!asteroidBelt)
		{
			probability = Random.Range (0, 100);
			if (probability > 98)
			{
				asteroidBelt = true;
				timeOffAsteroidBelt = Time.time;
			} 
			else 
			{
				delayTime = Time.time;
				if (Time.time - delayTime > 3.0f)
					delayTime = Time.time;			
			}
		}
		if(asteroidBelt)       
		{
			Flash();
			if (Time.time - timeOffAsteroidBelt > 9.0f)      
			{
				asteroidBelt = false;
				delayTime = Time.time;
				if (Time.time - delayTime > 6.0f)
					delayTime=Time.time;          
			}
			
			int enemyIndex = Random.Range(0, asteroids.Length);
			TrashMan.spawn(asteroids[enemyIndex], new Vector2(Random.Range(1, 12), transform.position.y), transform.rotation);     
		} 
	}
}
