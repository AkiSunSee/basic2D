using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawner")]
    public GameObject objPrefab;
    public GameObject SpawnPos;
    public List<GameObject> objects;
    public float SpawnTimer =0f;
    public float SpawnDelay;
    public float maxObj;

    public string objPrefabName = "";
    public string SpawnPosName = "";

    private void Awake() {
        this.objects = new List<GameObject>();  
        this.objPrefab = GameObject.Find(this.objPrefabName);
        this.SpawnPos = GameObject.Find(this.SpawnPosName);
        this.objPrefab.SetActive(false);
    }

    public void Update()
    {
        this.Spawn();

        this.CheckDead();
    }

    protected virtual void Spawn(){
        
    }
    protected virtual void CheckDead(){
        GameObject @object;
        for (int i=0;i<this.objects.Count;i++){
            @object = this.objects[i];
            if(@object == null) this.objects.RemoveAt(i);
        }
    }
}
