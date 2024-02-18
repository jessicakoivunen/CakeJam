using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volumeUpdater : MonoBehaviour
{
    private void Awake()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("MainVolume");
    }
}
