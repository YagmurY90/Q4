using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audSyc : MonoBehaviour
{
    public Text volumeAmount;

    public Slider sliderr;

    private void Start()
    {
        LoadAudio();
    }

    public void SetAudio(float value)
    {
        AudioListener.volume=value;
        volumeAmount.text=((int)(value*100)).ToString();
        SaveAudio();
    }

    private void SaveAudio()
    {
        PlayerPrefs.SetFloat("audioVolume", AudioListener.volume);
    }

    private void LoadAudio()
    {
        if (PlayerPrefs.HasKey("audioVolume"))
        {
            AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
            sliderr.value = PlayerPrefs.GetFloat("audioVolume");
        }
        else
        {
            PlayerPrefs.SetFloat("audioVolume", 1f);
            AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
            sliderr.value = PlayerPrefs.GetFloat("audioVolume");
        }
       



    }
}

