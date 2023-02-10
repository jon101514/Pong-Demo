using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    // Singleton Design Pattern -- when only one of something needs to exist
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;

    int leftScore = 0;
    int rightScore = 0;
    // Function -- AddScore to either player, left and right
    // Update the DATA internally, and then UPDATE IT VISUALLY for the players using the UI.

    // Start is called before the first frame update
    void Start() {
        // If there is NO instance...
        if (instance == null) {
            instance = this; // THen this is the instance.
        }
    }

    public void AddScore(bool didLeftScore, int pointsScored) {
        if (didLeftScore) {
            leftScore = leftScore + pointsScored;
        } else {
            rightScore += pointsScored;
            // rightScore -=, *= /= %=
        }
        Debug.Log(leftScore + " : " + rightScore);
        scoreText.text = leftScore + " : " + rightScore;
    }
}
