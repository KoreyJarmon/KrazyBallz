using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpScript : MonoBehaviour
{
    public GM gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindWithTag("GM").GetComponent<GM>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "bottom")
        {
            gm.moreBalls();
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "brick" || collision.gameObject.tag == "ball" || collision.gameObject.tag == "power")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }
}
