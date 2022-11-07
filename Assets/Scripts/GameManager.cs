using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public SoundManager soundManager;
    public Score score;

    private void Start()
    {
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
        SceneManager.LoadScene(0);
    }
}
