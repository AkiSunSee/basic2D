using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Spawner
{
    private void Reset() {
        this.objPrefabName = "EnemyPrefab";
        this.SpawnPosName = "EnemySpawnPos";
        this.SpawnDelay = 3f;
        this.maxObj = 1;
    }

    protected override void Spawn(){

        if (PlayerCtrl.instance.damageReceiver.IsDead()) return;
        if (this.objects.Count >= this.maxObj) return;
        this.SpawnTimer +=Time.deltaTime;
        if(this.SpawnTimer<this.SpawnDelay) return;
        this.SpawnTimer = 0;

        GameObject enemy = Instantiate(this.objPrefab);
        enemy.transform.position = this.SpawnPos.transform.position;
        enemy.transform.parent = transform;
        enemy.SetActive(true);

        this.objects.Add(enemy);
    }
}
