using UnityEngine;
using System.Collections;

public class LoadDangerSprite : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Resources.Load<UnityEngine.Sprite>("Sprites/DangerAsteroidBelt");
        spriteRenderer.enabled = false;
    }

}
