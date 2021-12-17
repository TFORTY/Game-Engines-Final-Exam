using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource a;

    private void Awake()
    {
        a = GetComponent<AudioSource>();   
    }

    private void OnEnable()
    {
        Duck.shoot += PlayAudio;
    }

    private void OnDisable()
    {
        Duck.shoot -= PlayAudio;
    }

    private void PlayAudio()
    {
        a.Play();
    }

}