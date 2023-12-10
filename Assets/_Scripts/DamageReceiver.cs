using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    [SerializeField] protected int hp = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Receive(int damage){
        this.hp -= damage;
    }

    public virtual bool IsDead(){
        return(this.hp <= 0);
    }


}
