using core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundController : Singleton<SoundController>
{
    protected SoundController() { }

    public AudioSource mainAudio;

    private void Start()
    {
        mainAudio = Camera.main.GetComponentInChildren<AudioSource>();
    }

}
