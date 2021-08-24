using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
   public AudioMixer mixer;
   float sliderValue = 0.3f;

    public void SetLevel(float sliderValue)
    {
        mixer.SetFloat("MenuMusicVol", Mathf.Log10(sliderValue) *10);
    }

}
