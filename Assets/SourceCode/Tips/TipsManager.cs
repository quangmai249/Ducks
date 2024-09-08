using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TipsManager : MonoBehaviour
{
    public TextMeshProUGUI textTips;
    [SerializeField] List<string> tips;
    void Start()
    {
        RandomTextTips();
        StartCoroutine(nameof(NextToGameplay));
    }
    void RandomTextTips()
    {
        int index = Random.Range(0, tips.Count);
        textTips.text = tips[index];
    }
    IEnumerator NextToGameplay()
    {
        yield return new WaitForSeconds(Random.Range(2f, 4f));
        SceneManager.LoadScene("GamePlay", LoadSceneMode.Single);
    }
}
