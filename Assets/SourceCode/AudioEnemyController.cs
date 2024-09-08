using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEnemyController : MonoBehaviour
{
    public AudioClip audioClipExplosions;
    public AudioClip audioDuckDead;

    public Setting setting;

    private AudioSource m_AudioSource;
    private GameManager gameManager;
    private Ray ray;
    private RaycastHit hit;
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        m_AudioSource = GetComponent<AudioSource>();
        m_AudioSource.volume = setting.GetVolume();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            SetAudioWhenClickedEnemy();
    }
    private void SetAudioWhenClickedEnemy()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 100) && gameManager.isGamePause == false)
        {
            if (hit.transform.gameObject.CompareTag("Rocket"))
            {
                m_AudioSource.PlayOneShot(audioClipExplosions, 1f);
            }
            if (hit.transform.gameObject.CompareTag("Duck"))
            {
                m_AudioSource.PlayOneShot(audioDuckDead, 1f);
            }
        }
    }
}
