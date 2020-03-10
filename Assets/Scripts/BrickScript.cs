using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour{

    public GM gm;
    public GameObject powerUp;
    // Start is called before the first frame update
    void Start(){
        gm = GameObject.FindWithTag("GM").GetComponent<GM>();
        Physics2D.IgnoreCollision(powerUp.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update(){
        
    }

    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag=="ball"){
            gm.IncrementScore();
            if (gm.score % 3 == 0){
                Instantiate(powerUp, transform.position, transform.rotation);
            }
            Destroy(gameObject);
        }
    }
}
