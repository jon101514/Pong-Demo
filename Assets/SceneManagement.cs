using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    // Singleton Design Pattern -- when only one of something needs to exist
    public static SceneManagement instance;

    // Start is called before the first frame update
    void Start() {
        // If there is NO instance...
        if (instance == null) {
            instance = this; // THen this is the instance.
        }
        // Time.timeScale = 4;
    }

    public void ResetGame() {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame() {
        Application.Quit();
    }
}
