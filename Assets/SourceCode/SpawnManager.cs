using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<Rigidbody> rb_duck;
    public List<Rigidbody> rb_boom;
    [SerializeField] float speed = 1f;
    [SerializeField] float xRange = 4f;
    [SerializeField] float yRange = 9f;
    [SerializeField] float speedRate = 0.0005f;
    [SerializeField] int index = 0;
    private GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        StartCoroutine(nameof(StartSpawn));
    }
    IEnumerator StartSpawn()
    {
        yield return new WaitForSeconds(gameManager.timeCountdownStartGame + 1);
        while (gameManager.isGameOver == false)
        {
            if (rb_duck.Count > 0)
            {
                yield return new WaitForSeconds(RandomSpeedSpawnDuck());
                Instantiate(rb_duck[RandomEnemy(rb_duck)], RandomPos(), rb_duck[RandomEnemy(rb_duck)].rotation);
                speed -= speedRate;
            }
            if (rb_boom.Count > 0)
            {
                yield return new WaitForSeconds(RandomSpeedSpawnBoom());
                Instantiate(rb_boom[RandomEnemy(rb_boom)], RandomPosY(), rb_boom[RandomEnemy(rb_boom)].rotation);
            }
        }
    }
    float RandomSpeedSpawnBoom()
    {
        return Random.Range(speed * 5, speed * 10);
    }
    float RandomSpeedSpawnDuck()
    {
        return Random.Range(speed, speed * 2);
    }
    int RandomEnemy(List<Rigidbody> _rb)
    {
        index = Random.Range(0, _rb.Count);
        return index;
    }
    Vector3 RandomPosY()
    {
        return new Vector3(transform.position.x, Random.Range(1, yRange), transform.position.z);
    }
    Vector3 RandomPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), transform.position.y, transform.position.z);
    }
}
