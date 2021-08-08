using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource volumeAudio;
    public Slider volumeSlider1;
    public AudioSource volumeAudio1;
    public AudioSource volumeAudio2;
    public AudioSource volumeAudio3;
    public AudioSource volumeAudio4;
    void Update()
    {
        volumeAudio.volume = volumeSlider.value;
        volumeAudio1.volume = volumeSlider.value;
        volumeAudio2.volume = volumeSlider1.value;
        volumeAudio3.volume = volumeSlider1.value;
        volumeAudio4.volume = volumeSlider1.value;

    }
}
