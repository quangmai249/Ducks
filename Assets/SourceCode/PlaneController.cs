using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlaneController : MonoBehaviour
{
    private GameManager gameManager;
    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Duck"))
        {
            Destroy(other.gameObject);
            gameManager.heart--;
        }
        if (other.gameObject.CompareTag("Rocket"))
        {
            Destroy(other.gameObject);
        }
    }
}
