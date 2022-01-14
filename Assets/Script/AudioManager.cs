using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void chgbgm(AudioClip music)
    {
        if (bgm.clip.name == music.name)
            return;
        bgm.Stop();
        bgm.clip = music;
        bgm.Play();
    }
}
