using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour
{
	public AudioClip playerDeathSound;
	public bool shieldState = false;

	private Renderer ShieldRenderer;
	private float shieldOnTime = 0.0f;
    private int shieldCount = 1;

    void Start()
    {
        //ShieldRenderer = GameObject.Find("Ship/ShieldSprite").GetComponent<Renderer>();
		ShieldRenderer = HGetComponentGeneric.ByName<Renderer>("Ship/ShieldSprite");
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
