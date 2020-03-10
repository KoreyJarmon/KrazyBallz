using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour{
    public Rigidbody2D rb;
    public float speed;
    public float maxX;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        float x = Input.GetAxis("Horizontal");
        if (x < 0){
            MoveLeft();
        }
        if (x > 0){
            MoveRight();
        }
        if (x == 0){
            Stop(); 
        }

        Vector3 pos = transform.position;           //store current position
        pos.x = Mathf.Clamp(pos.x,-maxX,maxX);      //limiting position
        transform.position = pos;                   //storing the limited position
    }

    void MoveLeft(){
        rb.velocity = new Vector2(-speed, 0);
    }

    void MoveRight(){
        rb.velocity = new Vector2(speed,0);
    }

    void Stop(){
        rb.velocity = Vector2.zero;
    }
}
