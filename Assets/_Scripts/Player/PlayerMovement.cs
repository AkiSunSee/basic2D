using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] // auto add Rigidbody 2D if missing
public class PlayerMovement : MonoBehaviour
{
    protected Rigidbody2D rb2d;

    public Vector2 velocity = new Vector2(0f,0f);
    public float pressHorizontal = 0f;
    public float pressVertical = 0f;
    [SerializeField] public float speedUp = 0.2f;
    [SerializeField] public float speedDown = 0.2f;
    [SerializeField] public float speedMax = 20f;
    public float speedHorizontal = 3f;
    public bool autoRun = false;
    private void Awake() {
        this.rb2d = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.pressHorizontal = Input.GetAxis("Horizontal");
        this.pressVertical = Input.GetAxis("Vertical");

        if(this.autoRun) this.pressVertical = 1;
    }

    private void FixedUpdate() {
        this.UpdateSpeed();
    }

    public virtual void UpdateSpeed(){
        this.velocity.x = this.pressHorizontal * speedHorizontal;
        this.UpdateSpeedUp();
        this.UpdateSpeedDown();
        this.rb2d.MovePosition(this.rb2d.position + this.velocity * Time.fixedDeltaTime);
    }

    protected virtual void UpdateSpeedUp(){
        if(this.pressVertical <= 0) return;

        this.velocity.y += this.speedUp;

        if(this.velocity.y > this.speedMax) this.velocity.y = this.speedMax;

        if(transform.position.x < -10 || transform.position.x > 10){
            this.velocity.y -= 1;
            if(this.velocity.y < 3) this.velocity.y =3;
        }
    }

    protected virtual void UpdateSpeedDown(){
        if(this.pressVertical != 0) return;
        this.velocity.y -= this.speedDown;
        if(this.velocity.y < 0) this.velocity.y = 0;
    }
}

