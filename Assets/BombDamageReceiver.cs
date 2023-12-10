using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDamageReceiver : DamageReceiver
{
    //[Header("Bomb")]
    public override void Receive(int damage){
        base.Receive(damage);
        if(this.IsDead()){
            Destroy(gameObject) ;
            EfffectManager.instance.SpawnVFX("Bomb_explosion", transform.position, transform.rotation);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
