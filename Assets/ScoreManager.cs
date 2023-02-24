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

    int maxScore = 5;
    // Function -- AddScore to either player, left and right
    // Update the DATA internally, and then UPDATE IT VISUALLY for the players using the UI.

    // Start is called before the first frame update
    void Start() {
        // If there is NO instance...
        if (instance == null) {
            instance = this; // THen this is the instance.
        }
        // Time.timeScale = 4;
    }

    public void AddScore(bool didLeftScore, int pointsScored) {
        // Updating the score
        if (didLeftScore) {
            leftScore = leftScore + pointsScored;
        } else {
            rightScore += pointsScored;
            // rightScore -=, *= /= %=
        }

        /**
        if leftScore >= maxScore, then change scoreText to be a winning message and reset the game after some time
        // likewise with rightscore
         */
        // Checking wins
        if (leftScore >= maxScore) {
            scoreText.text = "LEFT PLAYER WINS!";
            Invoke("Reset", 2);
        } else if (rightScore >= maxScore) {
            scoreText.text = "RIGHT PLAYER WINS!";
            Invoke("Reset", 2);
        } else {
            // Updating the UI
            Debug.Log(leftScore + " : " + rightScore);
            scoreText.text = leftScore + " : " + rightScore;
        }
    }

    // Reset the game IMMEDIATELY after being called.
    void Reset() {
        SceneManagement.instance.ResetGame();
    }
}
