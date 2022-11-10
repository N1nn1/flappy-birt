using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void startGame()
    {
        SceneManager.LoadScene(1);
    }
}
