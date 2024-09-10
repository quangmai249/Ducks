using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ConnanManager : MonoBehaviour
{
    public ParticleSystem connanFire;
    public Setting setting;
    private AudioSource connanFireSound;
    private GameManager gameManager;
    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        connanFireSound = GetComponent<AudioSource>();
        connanFireSound.volume = setting.GetVolume();
    }
    private void Update()
    {
        if (gameManager.isGameOver == false)
        {
            transform.LookAt(Input.mousePosition, Vector3.forward);
            if (gameManager.isGameStart == true)
                ConnanStartFire();
        }
    }
    void ConnanStartFire()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Instantiate(connanFire, gameObject.transform.position + new Vector3(1.5f, -0.5f, 0), gameObject.transform.rotation);
            connanFireSound.Play();
        }
    }
}
