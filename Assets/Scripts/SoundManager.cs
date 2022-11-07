using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
    
    public static AudioClip flySound, loseSound, scoreSound;
    static AudioSource audioSrc;

    void Start() {
        flySound = Resources.Load<AudioClip> ("fly");
        loseSound = Resources.Load<AudioClip> ("lose");
        scoreSound = Resources.Load<AudioClip> ("score");

        audioSrc = GetComponent<AudioSource>();
    }
 
    void Update() {}

    public static void playSound(string clip) {
        switch (clip) {
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
