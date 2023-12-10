using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageReceive : DamageReceiver
{

    protected PlayerCtrl playerCtrl;
    public GameObject btnGameOver;
    private void Awake() {
        this.playerCtrl = GetComponent<PlayerCtrl>();
    }
    public override void Receive(int damage){
        base.Receive(damage);
        if(this.IsDead()) {
            this.playerCtrl.playerStatus.Dead();
            UIManager.instance.btnGameOver.SetActive(true);
        }
    }
}
