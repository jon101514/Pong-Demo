using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    public int numInt = 8;
    public float numF = 8f;

    public KeyCode upKey;
    public KeyCode downKey;

    private float speed = 3.5f; // For floats, add the f at the end


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // 
        /* 
        If the player presses up, move the paddle up
        If the player presses down, move the paddle down
        */
        
        if (Input.GetKey(upKey)) {
            // lowercase t transform = this object's transform
            // uppercase t Transform = the entire Transform class
            transform.Translate(Vector2.up * Time.deltaTime * speed);
        }
        if (Input.GetKey(downKey)) {
            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }
    }
}
