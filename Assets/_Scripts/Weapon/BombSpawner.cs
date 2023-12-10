using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : Spawner
{
    private void Reset() {
        this.objPrefabName = "BombPrefab";
        this.SpawnPosName = "BombSpawnPos";
        this.SpawnDelay = 2f;
        this.maxObj = 7;
    }

    protected override void Spawn(){
        if (this.objects.Count >= maxObj) return;
        this.SpawnTimer += Time.deltaTime;
        if (this.SpawnTimer < this.SpawnDelay) return;
        this.SpawnTimer = 0f;
        
        
        int index = this.objects.Count +1;
        GameObject minion = Instantiate(this.objPrefab); //create GameObject with a GameObject model
        minion.name = "Bomb #"+index;
        //minion.AddComponent<PlayerPosition>(); add script to object
        minion.transform.position = this.SpawnPos.transform.position;
        minion.gameObject.SetActive(true);
        this.objects.Add(minion);
    }
}
