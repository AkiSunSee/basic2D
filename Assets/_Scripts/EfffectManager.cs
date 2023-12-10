using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfffectManager : MonoBehaviour
{
    static public EfffectManager instance;
    public List<GameObject> effects;
    // Start is called before the first frame update
    void Start()
    {
        EfffectManager.instance = this;
        this.LoadEffects();
    }

    protected virtual void LoadEffects(){
        this.effects = new List<GameObject>();
        foreach (Transform child in transform)
        {
            this.effects.Add(child.gameObject);
            child.gameObject.SetActive(false);
        }
    }

    public virtual void SpawnVFX(string effectName, Vector3 position, Quaternion rot){
        GameObject effect = this.Get(effectName);
        GameObject newEffect = Instantiate(effect, position, rot); //Instantiate - cloning original Object
        newEffect.gameObject.SetActive(true);
    }

    protected virtual GameObject Get(string effectName){
        foreach (GameObject child in this.effects){
            if(child.name == effectName) return child;
        }
        return null;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
