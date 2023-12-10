using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    [SerializeField] private float playerPosX;  
    List<GameObject> minions;
    public GameObject minionPrefb;
    protected float spawnTimer = 0f;
    protected float spawnDelay = 1f;
   
    // Start is called before the first frame update
    void Start()
    {
        this.minions = new List<GameObject>();   
    }

    // Update is called once per frame
    void Update()
    {
        this.Spawn();

        this.CheckMinionDead();
    }

    void Spawn(){
        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay) return;
        this.spawnTimer = 0f;
        if (this.minions.Count >= 7) return;
        
        int index = this.minions.Count +1;
        GameObject minion = Instantiate(this.minionPrefb); //create GameObject with a GameObject model
        minion.name = "Bomb #"+index;
        //minion.AddComponent<PlayerPosition>(); add script to object
        minion.transform.position = transform.position;
        minion.gameObject.SetActive(true);
        this.minions.Add(minion);
    }

    void CheckMinionDead(){
        GameObject minion;
        for (int i=0;i<this.minions.Count;i++){
            minion = this.minions[i];
            if(minion == null) this.minions.RemoveAt(i);
        }
       
    }

}
