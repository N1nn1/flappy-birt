using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public SoundManager soundManager;
    public Score score;
    public HighScore highScore;

    private void Start()
    {
        updatehighScore();
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void gameOver()
    {
        Time.timeScale = 0;
        gameOverCanvas.SetActive(true);
        soundManager.playSound("lose");
    }

    public void restart()
    {
        SceneManager.LoadScene(1);
    }

    public void goToMainMenu()
    {
        gameOverCanvas.SetActive(false);
        SceneManager.LoadScene(0, LoadSceneMode.Additive);
    }

    public void updatehighScore()
    {
        if (score.score > highScore.highScore)
        {
            PlayerPrefs.SetInt("highScore", score.score);
        }
    }
}
