using UnityEngine;

public class HighScore : MonoBehaviour
{
    public int highScore = 0;

    private void Update()
    {
        highScore = PlayerPrefs.GetInt("highScore", 0);
    }
}
