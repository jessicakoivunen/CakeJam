using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Slider musicVolumeSlider;
    public Slider effectsVolumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        musicVolumeSlider.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
        effectsVolumeSlider.value = PlayerPrefs.GetFloat("EffectsVolume", 0.75f);
    }


    public void UpdateMusicVolume()
    {
        PlayerPrefs.SetFloat("MainVolume", musicVolumeSlider.value);
        AudioListener.volume = PlayerPrefs.GetFloat("MainVolume");
    }
}
