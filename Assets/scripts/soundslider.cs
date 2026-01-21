using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class soundslider : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioMixer Mixer;

    public void SetVolume()
    {
        Mixer.SetFloat("volume", volumeSlider.value);
    }
}
