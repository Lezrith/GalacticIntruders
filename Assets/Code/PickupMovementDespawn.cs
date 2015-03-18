using UnityEngine;
using System.Collections;

public class PickupMovementDespawn : MonoBehaviour
{
    private Shield ShieldScript;
    public float Speed;

    void Start()
    {
        ShieldScript = HGetComponentGeneric.ByName<Shield>("Ship");
    }

    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x - Speed * Time.deltaTime, transform.position.y);
        if(transform.position.x<-4.5f)
        {
            TrashMan.despawn(this.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.transform.name=="Ship")
        {
            TrashMan.despawn(this.gameObject);
            ShieldScript.AddShieldCharge();
        }
    }
}
