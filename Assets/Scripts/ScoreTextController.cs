using UnityEngine.UI;
using UnityEngine;

public class ScoreTextController : MonoBehaviour
{
    public Text text;
    public Score score;

    void Update()
    {
        text.text = score.score.ToString();
    }
}
