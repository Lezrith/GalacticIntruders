using UnityEngine;
using System.Collections;

public class SpawnPickups : MonoBehaviour
{
    public GameObject[] Pickups;
    public float spawnTime = 10f;
    public float spawnDelay = 2f;

    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }
    void Spawn()
    {
        int Index = Random.Range(0, Pickups.Length);
        TrashMan.spawn(Pickups[Index], new Vector2(transform.position.x, Random.Range(-1790f / 1000, 1790f / 1000)), transform.rotation);
    }
}

