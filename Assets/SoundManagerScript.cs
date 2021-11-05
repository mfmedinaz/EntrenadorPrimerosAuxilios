using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip shockSound;
    static AudioSource audioSrc;
    void Start()
    {
        shockSound = Resources.Load<AudioClip>("shockSound");
        audioSrc = GetComponent<AudioSource>();
        
    }

public static void playSound()
    {
        audioSrc.PlayOneShot(shockSound);
    }
}
