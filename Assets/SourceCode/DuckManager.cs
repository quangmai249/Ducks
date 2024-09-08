using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckManager : MonoBehaviour
{
    [SerializeField] float minRangeUp = 10f;
    [SerializeField] float maxRangeUp = 13f;
    [SerializeField] float speedTorque = 2f;

    public ParticleSystem parDestroyDuck;
    public Setting setting;

    private AudioSource audioSource;

    private Rigidbody rb;
    private GameManager gameManager;
    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        audioSource = GetComponent<AudioSource>();

        if (setting.GetVolume() == 0)
            audioSource.mute = true;

        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.up * RandomRangeUp(), ForceMode.Impulse);
        rb.AddRelativeTorque(RandomTorque(), RandomTorque(), speedTorque / 2, ForceMode.Impulse);
    }
    private void OnMouseDown()
    {
        if (gameManager.isGameOver == false && gameManager.isGamePause == false)
        {
            gameManager.SetScore();
            Destroy(rb.gameObject);
            Instantiate(parDestroyDuck, transform.position, parDestroyDuck.transform.rotation);
        }
    }
    float RandomTorque()
    {
        return Random.Range(-speedTorque, speedTorque);
    }
    float RandomRangeUp()
    {
        return Random.Range(minRangeUp, maxRangeUp);
    }
}
