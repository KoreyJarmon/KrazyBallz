using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour{
    public Rigidbody2D rb;
    public float ballForce;
    bool gameStarted = false;
    public GM gm;
    GameObject extraBall;

    // Start is called before the first frame update
    void Start(){
        gm = GameObject.FindWithTag("GM").GetComponent<GM>();
    }

    // Update is called once per frame
    void Update(){
        if ((Input.GetKeyUp(KeyCode.Space) || Input.touchCount > 0) && gameStarted==false){
            transform.SetParent(null);
            rb.isKinematic = false;
            rb.AddForce(new Vector2(ballForce, ballForce));
            gameStarted = true;
        }
        if (gm.upgrade == true){
            extraBall = Instantiate(gameObject, transform.position, transform.rotation);
            extraBall.gameObject.tag = "ball";
            extraBall.GetComponent<Rigidbody2D>().AddForce(new Vector2(ballForce, ballForce));

            gm.upgrade = false;
        }
    }
}
