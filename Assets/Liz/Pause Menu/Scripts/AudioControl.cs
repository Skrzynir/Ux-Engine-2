using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioControl : MonoBehaviour
{
    public AudioMixer Mixer;
    public string ParamName;
    private Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
        float vol = (PlayerPrefs.GetFloat(ParamName, 1));
        slider.value = vol;
        Change(vol);
    }

    public void Change(float value)
    {
        PlayerPrefs.SetFloat(ParamName, value);
        value *= 80;
        value -= 80;
        Mixer.SetFloat(ParamName, value);        
    }

}
