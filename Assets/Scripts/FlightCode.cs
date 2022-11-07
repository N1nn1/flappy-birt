using UnityEngine;

public class FlightCode : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    public Rigidbody2D rb;
    public SoundManager soundManager;
    public Score score;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.timeScale != 0)
        {
            soundManager.playSound("fly");
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Log")
        {
            soundManager.playSound("score");
            score.score++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.gameOver();
    }
}
