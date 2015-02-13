using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{

    private bool pausedGame = false;
    private Shooting shooting;
    private ShipMovement moving;
    private GameObject paused;

    void Start()
    {
        shooting = GameObject.FindWithTag("PlayerShip").GetComponent<Shooting>();
        moving = GameObject.FindWithTag("PlayerShip").GetComponent<ShipMovement>();
        paused = GameObject.Find("Paused");
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
            pausedGame = !pausedGame;

        if (pausedGame)
        {
            Time.timeScale = 0.0f;
            shooting.enabled = false;
            moving.enabled = false;
            paused.renderer.enabled = true;
        }

        if (!pausedGame)
        {
            Time.timeScale = 1.0f;
            shooting.enabled = true;
            moving.enabled = true;
            paused.renderer.enabled = false;
        }
    }

}
