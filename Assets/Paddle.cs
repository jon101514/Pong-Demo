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
    private float baseSpeed = 3.5f;
    private float accel = 1/4f;
    private float maxSpeed = 6f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // 
        /* 
        while the button is being held down, increase speed by accel up to a MAXIMUM
        when the button is RELEASED, reset the speed to base value
        */
        
        if (Input.GetKey(upKey) && transform.position.y < 3) { // and the player's y position is less than 3
        // if (Input.GetKey(upKey) || transform.position.y < 3) { // || is for "OR" meaning either left OR right (OR BOTH) can be true
            // lowercase t transform = this object's transform
            // uppercase t Transform = the entire Transform class
            ProcessAccel();
            transform.Translate(Vector2.up * Time.deltaTime * speed);
        }
        if (Input.GetKey(downKey) && transform.position.y > -3) { 
            ProcessAccel();
            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }
        // When button is RELEASED, resest the speed to base value
        if (Input.GetKeyUp(upKey) || Input.GetKeyUp(downKey)) {
            Debug.Log("RESETSPEED");
            speed = baseSpeed;
        }
    }

    void ProcessAccel() {
        speed += accel;
        if (speed > maxSpeed) {
            speed = maxSpeed;
        }
    }
}
