using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageReceive : DamageReceiver
{
    protected EnemyCtrl enemyCtrl;
    private void Awake() {
        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }
    public override void Receive(int damage){
        base.Receive(damage);
        if(this.IsDead()) {
            this.enemyCtrl.despawner.Despawn();
        }
    }
}
