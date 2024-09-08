using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour
{
    public Setting setting;
    public Slider sliderVol;
    private AudioSource _audioSource;
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.volume = setting.GetVolume();
        sliderVol.value = .5f;
    }
    private void Update()
    {
        setting.SetVolume(sliderVol.value);
    }
}
