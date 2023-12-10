using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceDespawner : MonoBehaviour
{
    protected float distance = 0;

    private void FixedUpdate() {
        this.UpdateSpace();
    }

    public virtual void UpdateSpace(){
        this.distance = Vector2.Distance(PlayerCtrl.instance.transform.position, transform.position);
        if(this.distance > 50) this.Despawn();
    }

    protected virtual void Despawn(){
        Destroy(gameObject);
    }
}
