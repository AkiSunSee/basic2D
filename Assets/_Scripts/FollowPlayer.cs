using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public float speed = 27f;
    public float distancelimit = 0.5f;
    public float ranPos = 0;
    // Start is called before the first frame update
    private void Awake() {
        this.player = PlayerCtrl.instance.transform;

        this.ranPos = Random.Range(-10,10);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate() {
        this.Follow();
    }

    void Follow(){
        Vector3 pos = this.player.position;
        pos.x = ranPos;

        Vector3 distance = pos - transform.position;
        if (distance.magnitude >= distancelimit){
            Vector3 targetPoint = pos - distance.normalized *distancelimit;
            transform.position = Vector3.MoveTowards(transform.position, targetPoint, this.speed*Time.fixedDeltaTime);
        }
    }
}
