using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip flySound, loseSound, scoreSound;
    public AudioSource audioSrc;

    public void playSound(string clip)
    {
        switch (clip)
        {
            case "fly":
                audioSrc.PlayOneShot(flySound);
                break;  
            case "lose":
                audioSrc.PlayOneShot(loseSound);
                break;
            case "score":
                audioSrc.PlayOneShot(scoreSound);
                break;
        }
    }
}
