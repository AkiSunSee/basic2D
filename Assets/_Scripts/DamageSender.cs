using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : MonoBehaviour
{   
    protected EnemyCtrl enemyCtrl;
   
    private void Awake() {
        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        // if (other.CompareTag("Bomb")) {
        //     Destroy(gameObject);
        // }
        // else{
        // DamageReceiver damageReceiver = other.GetComponent<DamageReceiver>();
        // damageReceiver.Receive(1);
        // }
        DamageReceiver damageReceiver = other.GetComponent<DamageReceiver>();
        //even other is only have ABCDamageReceiver inherit from DamageReceiver, variant damageReveiver is still != null
        if (damageReceiver != null) 
        damageReceiver.Receive(1); //player take 1 damage
        //Destroy(other.gameObject);
        EnemyDamageReceive EDR = GetComponent<EnemyDamageReceive>();
        EDR.Receive(1);
        //this.enemyCtrl.despawner.Despawn();
    }
}
