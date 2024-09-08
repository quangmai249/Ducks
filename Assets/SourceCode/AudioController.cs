using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public List<AudioClip> audioClips;
    public Setting setting;

    private AudioSource m_AudioSource;
    private GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        m_AudioSource = GetComponent<AudioSource>();
        PlayAudioSource();
    }
    private void Update()
    {
        if (gameManager.isGamePause == true)
            m_AudioSource.Pause();
    }
    AudioClip RandomAudioClip()
    {
        return audioClips[Random.Range(0, audioClips.Count)];
    }
    void PlayAudioSource()
    {
        m_AudioSource.volume = setting.GetVolume();
        m_AudioSource.loop = true;
        if (audioClips.Count > 0)
            m_AudioSource.clip = RandomAudioClip();
        m_AudioSource.Play();
    }
}
