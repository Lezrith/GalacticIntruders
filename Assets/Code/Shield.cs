using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour
{

    private float shieldOnTime = 0.0f;
    public bool shieldState = false;
    private int shieldCount = 1;
    private Renderer ShieldRenderer;

    void Start()
    {
        ShieldRenderer = GameObject.Find("Ship/ShieldSprite").GetComponent<Renderer>();
    }

    void Update()
    {
        if ((Input.GetButtonDown("Shield")) && (!shieldState) && (shieldCount > 0))
        {
            shieldOnTime = Time.time;
            shieldState = true;
            shieldCount--;
            Debug.Log("ShieldON");
            ShieldRenderer.enabled = true;
        }
        if (shieldState && Time.time - shieldOnTime > 3.0f)
        {
            shieldState = false;
            ShieldRenderer.enabled = false;
            Debug.Log("ShieldOFF");
        }

    }
}
