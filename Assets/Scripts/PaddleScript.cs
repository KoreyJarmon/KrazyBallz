using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour{
    public Rigidbody2D rb;
    public float speed;
    public float maxX;
    private float width;
    private Vector3 position;

    // Start is called before the first frame update
    void Start(){
        width = (float)Screen.width / 2.0f;
    }


    // Update is called once per frame
    void Update(){
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 post = touch.position;
                post.x = (post.x - width) / width;
                position = new Vector3((post.x)*4, transform.position.y, 0.0f);
                transform.position = position;
            }
        }

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
