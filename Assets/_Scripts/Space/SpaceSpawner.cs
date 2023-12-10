using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceSpawner : MonoBehaviour
{
    protected GameObject spacePrefab;
    protected GameObject spaceSpawnPos;
    protected float distance = 0;
    protected GameObject spaceCurrent;
    protected int roadLayerOrder = 0;
    

    private void Awake() {
        this.spacePrefab = GameObject.Find("SpacePrefab");
        this.spaceSpawnPos = GameObject.Find("SpaceSpawnPos");
        this.spacePrefab.SetActive(false);

        this.spaceCurrent = this.spacePrefab;
        this.roadLayerOrder = (int) this.spacePrefab.transform.position.z;
        this.Spawn(this.spacePrefab.transform.position);
    }

    private void FixedUpdate() {
        this.UpdateSpace();
    }

    public virtual void UpdateSpace(){
        this.distance = Vector2.Distance(PlayerCtrl.instance.transform.position, this.spaceCurrent.transform.position);
        if(this.distance > 20) this.Spawn();
    }

    protected virtual void Spawn(){
        Vector3 pos = this.spaceSpawnPos.transform.position;
        pos.x = 0;
        pos.z = this.roadLayerOrder;
        
        this.Spawn(pos);
    }

    protected virtual void Spawn(Vector3 position){
        this.spaceCurrent = Instantiate(this.spacePrefab, position, this.spacePrefab.transform.rotation);
        this.spaceCurrent.transform.parent = transform;
        this.spaceCurrent.SetActive(true);
    }
}
