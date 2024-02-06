using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundMenager : MonoBehaviour
{
    [SerializeField] Slider volume_slider;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }

        else
        {
            Load();
        }
    }

    public void Change_Volume()
    {
        AudioListener.volume = volume_slider.value;
        Save();
    }

    private void Load()
    {
        volume_slider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volume_slider.value);
    }
}
