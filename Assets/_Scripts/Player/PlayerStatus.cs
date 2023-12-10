using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    protected PlayerCtrl playerCtrl;
    private void Awake() {
        this.playerCtrl = GetComponent<PlayerCtrl>();
    }

    public virtual void Dead(){
        Debug.Log("Dead");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
