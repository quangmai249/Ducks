using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrain : MonoBehaviour
{
    public GameObject train;
    private GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        StartCoroutine(nameof(CoroutineTrain));
    }
    IEnumerator CoroutineTrain()
    {
        while (gameManager.isGameOver == false)
        {
            yield return new WaitForSeconds(RandomCoroutine());
            Instantiate(train, train.transform.position, train.transform.rotation);
        }
    }
    int RandomCoroutine()
    {
        return Random.Range(7, 12);
    }
}
