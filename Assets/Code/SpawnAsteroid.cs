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
    // Use this for initialization
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
        if (Time.time - timeIfAsteroidBelt > 5.0f)
        {
            asteroidBelt = true;
            timeOffAsteroidBelt = Time.time;
        }
        if(asteroidBelt)
        {
            Flash();
            if (Time.time - timeOffAsteroidBelt > 5.0f)
            {
                asteroidBelt = false;
                timeIfAsteroidBelt = Time.time;
            }
            
                int enemyIndex = Random.Range(0, asteroids.Length);
                TrashMan.spawn(asteroids[enemyIndex], new Vector2(Random.Range(1, 12), transform.position.y), transform.rotation);
            
        }
    }
}
