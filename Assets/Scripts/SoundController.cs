using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioClip loseLife;
    public AudioClip brickBreak;
    public AudioClip platfromHit;

    public AudioSource soundManager;
    

    

    public void PlaySound(string clip)
    {
        switch (clip)
        {
            case "loseLife":
                soundManager.PlayOneShot(loseLife);
                break;
            case "brickBreak":
                soundManager.PlayOneShot(brickBreak);
                break;
            case "platformHit":
                soundManager.PlayOneShot(platfromHit);
                break;
        }
    }
}
