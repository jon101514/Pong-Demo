using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    // Store the ball's direction
    Vector2 dir;
    float speed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        ResetBall();
    }

    // Update is called once per frame
    void Update()
    {
        // Every frame, constantly update that ball's position by moving it.
        transform.Translate(dir * Time.deltaTime * speed);
    }

    // Zero position, randomize direction, normalize direction
    void ResetBall() {
        transform.position = Vector3.zero;
        dir = new Vector2(Random.Range(-1f, 1f), Random.Range(-1/2f, 1/2f));
        // Unit Vector == a vector whose magnitude is ALWAYS 1
        dir.Normalize();
    }

    // For solid, non-trigger collisions
    void OnCollisionEnter2D (Collision2D coll) {
        // if ball hits a wall, flip dir vertically
        // if ball hits the paddle, flip dir horizontally
        if (coll.gameObject.tag.Equals("Wall")) {
            dir.y = -dir.y;
        }
    }

    void OnTriggerEnter2D (Collider2D trig) {
        // if ball hits a Bound, go back to the center and re-randomize the direction
        if (trig.gameObject.tag.Equals("Bound")) {
            // Call the ScoreManager's AddScore function depending on if L or R player got the point
            if (transform.position.x > 0) { // Left Player scored
                ScoreManager.instance.AddScore(true, 1);
            } else { // Right Player scored
                ScoreManager.instance.AddScore(false, 1);
            }
            ResetBall();
        }
        if (trig.gameObject.tag.Equals("Paddle")) {
            dir.x = -dir.x;
        }
    }
}
