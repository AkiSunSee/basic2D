using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    static public PlayerCtrl instance;
    public PlayerStatus playerStatus;
    public DamageReceiver damageReceiver;

    private void Awake() {

        PlayerCtrl.instance = this;
        this.damageReceiver = GetComponent<DamageReceiver>();
        this.playerStatus = GetComponent<PlayerStatus>();
    }
}
