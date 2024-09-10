using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HeartManager : MonoBehaviour
{
    public List<RawImage> lsIconHeart;
    private GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {
        if (gameManager.isGameOver == true)
        {
            foreach (var item in lsIconHeart)
                item.gameObject.SetActive(false);
        }
        else
        {
            switch (gameManager.heart)
            {
                case 2:
                    lsIconHeart[0].gameObject.SetActive(false);
                    break;
                case 1:
                    lsIconHeart[1].gameObject.SetActive(false);
                    break;
                case 0:
                    lsIconHeart[2].gameObject.SetActive(false);
                    break;
            }
        }
    }
}
