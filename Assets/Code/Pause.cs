using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{

    private bool pausedGame = false;
    private Shooting shooting;
    private ShipMovement moving;
    private GameObject paused;
    private Renderer PausedRenderer;

    void Start()
    {
        shooting = GameObject.FindWithTag("PlayerShip").GetComponent<Shooting>();
        moving = GameObject.FindWithTag("PlayerShip").GetComponent<ShipMovement>();
        PausedRenderer = GameObject.Find("Paused").GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Pause"))
            pausedGame = !pausedGame;

        if (pausedGame)
        {
            Time.timeScale = 0.0f;
            shooting.enabled = false;
            moving.enabled = false;
            PausedRenderer.enabled = true;
        }

        if (!pausedGame)
        {
            Time.timeScale = 1.0f;
            shooting.enabled = true;
            moving.enabled = true;
            PausedRenderer.enabled = false;
        }
    }

}
