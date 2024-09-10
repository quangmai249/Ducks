using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RocketManager : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    public List<ParticleSystem> parExplosions;
    public ParticleSystem parHeart;

    public float xRange = 18f;

    public Setting setting;

    private Rigidbody rb;
    private AudioSource audioSource;
    private GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        audioSource = GetComponent<AudioSource>();

        if (setting.GetVolume() == 0)
            audioSource.mute = true;

        rb = GetComponent<Rigidbody>();
        rb.transform.rotation = Quaternion.Euler(0f, 0f, 90f);
        rb.AddRelativeForce(Vector3.left * speed, ForceMode.Impulse);
    }
    private void Update()
    {
        if (rb.gameObject.transform.position.x < -xRange)
            Destroy(rb.gameObject);
    }
    private void OnMouseDown()
    {
        if (gameManager.isGameOver == false && gameManager.isGamePause == false)
        {
            Destroy(rb.gameObject);
            gameManager.heart = 0;
            StartCoroutine(nameof(SpawnExplosions));
            StartCoroutine(nameof(SpawnHeart));
        }
    }
    IEnumerator SpawnHeart()
    {
        Instantiate(parHeart, parHeart.transform.position, parHeart.transform.rotation);
        yield return new WaitForSeconds(1);
    }
    IEnumerator SpawnExplosions()
    {
        ParExplosions().gameObject.transform.localScale = new Vector3(5f, 5f, 5f);
        Instantiate(ParExplosions(), PosExplosions(ParExplosions()), ParExplosions().transform.rotation);
        yield return new WaitForSeconds(1);
        gameManager.isGameOver = true;
    }
    ParticleSystem ParExplosions()
    {
        return parExplosions[RandomIndexPar()];
    }
    Vector3 PosExplosions(ParticleSystem par)
    {
        return new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, par.transform.position.z);
    }
    int RandomIndexPar()
    {
        return Random.Range(0, parExplosions.Count);
    }
}
