using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.RotateBomb();
    }

    private void RotateBomb(){
        Vector3 rotate = new Vector3(0,0,45);
        this.transform.Rotate(rotate * Time.fixedDeltaTime);
    }
}
