using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour{
    public GameObject brick;
    public static GM instance = null;
    public float width;
    public float height;
    public int score = 0;
    public bool upgrade = false;
    public Text scoreText;

    // Start is called before the first frame update
    void Start(){
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        Setup();
    }

    void Setup(){
     for (double y = 0; y<height; y++){
            for (double x = -2.4; x<width; x++){
                Instantiate(brick, new Vector3((float) x, (float) y, 0), Quaternion.identity);
                x -= 0.4;
            }
            y -= 0.5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore(){
        score++;
        scoreText.text = "Score: " + score;
    }

    public void moreBalls(){
        upgrade = true;
    }
}
