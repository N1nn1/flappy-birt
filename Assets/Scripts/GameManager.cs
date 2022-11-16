using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject menuCanvas;
    public SoundManager soundManager;
    public Score score;
    public HighScore highScore;

    private void Start()
    {
        updatehighScore();
        menuCanvas.SetActive(false);
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void gameOver()
    {
        Time.timeScale = 0;
        gameOverCanvas.SetActive(true);
        menuCanvas.SetActive(false);
        soundManager.playSound("lose");
    }

    public void startGame()
    {
        BGMusic.instance.GetComponent<AudioSource>().UnPause();
        SceneManager.LoadScene("Game Scene");
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void goToMainMenu()
    {
        BGMusic.instance.GetComponent<AudioSource>().Pause();
        menuCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
    }

    public void updatehighScore()
    {
        if (score.score > highScore.highScore)
        {
            PlayerPrefs.SetInt("highScore", score.score);
        }
    }
}
