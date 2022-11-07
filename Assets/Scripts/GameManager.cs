using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public GameObject gameOverCanvas;

    private void Start() {
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
        Score.score = 0;
    }

    public void gameOver() {
        Time.timeScale = 0;
        gameOverCanvas.SetActive(true);
        SoundManager.playSound("lose");
    }

    public void restart() {
        SceneManager.LoadScene(0);
    }
}
