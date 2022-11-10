using UnityEngine.UI;
using UnityEngine;

public class HighScoreTextController : MonoBehaviour
{
    public Text text;
    public HighScore highScore;

    void Update()
    {
        text.text = highScore.highScore.ToString();
    }
}
