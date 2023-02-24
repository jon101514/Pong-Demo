using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int x = 6;
    int y = -2;
    bool testing = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        // & | bitwise operators ; = assigning x = 4
        // == is for checking equality
        //AND
        if (x > 5 && testing == true) {
            Debug.Log("With AND, both left and right were true.");
        }
        //OR
        if (x > 5 || testing == true) {
            Debug.Log("With OR, only one of those left or right has to be true.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
