using UnityEngine;
using System.Collections;

public class LoadPausedSprite : MonoBehaviour {

    private SpriteRenderer sprite_renderer;
    // Use this for initialization
    void Start()
    {
        sprite_renderer = this.GetComponent<SpriteRenderer>();
        sprite_renderer.sprite = Resources.Load<UnityEngine.Sprite>("Sprites/paused");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
