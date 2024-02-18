using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public static soundManager soundManagement;
    public AudioClip[] sounds;
    private AudioSource audioSource;

    private void Awake()
    {
        soundManagement = this;
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void playSound(int clipId)
    {
        audioSource.PlayOneShot(sounds[clipId]);
    }
}
