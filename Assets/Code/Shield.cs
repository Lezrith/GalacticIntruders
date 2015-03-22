using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour
{
	public AudioClip playerDeathSound;
	public bool shieldState = false;

	private Renderer ShieldRenderer;
	private float shieldOnTime = 0.0f;
    static private int shieldCount = 1;
    private Renderer[] ShieldCounterBar;
    public int test;

    void Start()
    {
		ShieldRenderer = HGetComponentGeneric.ByName<Renderer>("Ship/ShieldSprite");
        shieldCount = 1;
        ShieldCounterBar = new Renderer[3];
        ShieldCounterBar[0] = HGetComponentGeneric.ByName<Renderer>("ShieldCounter/ShieldCounterBar1");
        ShieldCounterBar[1] = HGetComponentGeneric.ByName<Renderer>("ShieldCounter/ShieldCounterBar2");
        ShieldCounterBar[2] = HGetComponentGeneric.ByName<Renderer>("ShieldCounter/ShieldCounterBar3");
    }

    public void AddShieldCharge()
    {
        ShieldCounterBar[0] = HGetComponentGeneric.ByName<Renderer>("ShieldCounter/ShieldCounterBar1");
        ShieldCounterBar[1] = HGetComponentGeneric.ByName<Renderer>("ShieldCounter/ShieldCounterBar2");
        ShieldCounterBar[2] = HGetComponentGeneric.ByName<Renderer>("ShieldCounter/ShieldCounterBar3");
        if (shieldCount < 3)
        {
            ShieldCounterBar[shieldCount].enabled = true;
            shieldCount++;
        }
        
    }

    void Update()
    {
        if ((Input.GetButtonDown("Shield")) && (!shieldState) && (shieldCount > 0))
        {
            shieldOnTime = Time.time;
            shieldState = true;
            shieldCount--;
            ShieldCounterBar[shieldCount].enabled = false;
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
