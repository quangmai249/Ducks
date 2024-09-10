using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI textTimePlayed;
    public TextMeshProUGUI textCoin;
    public TextMeshProUGUI textCoinEarn;

    public RawImage iconCoin;
    public Button btnReset;
    public Button btnHome;

    public AudioClip audioClip;

    public ResultGame resultGame;
    public Setting setting;
    public Money money;
    public TopScore topScore;

    private AudioSource audioSource;
    private int score;
    [SerializeField] int scoreEarn = 10;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = setting.GetVolume();
        audioSource.loop = true;
        audioSource.PlayOneShot(audioClip, 1f);

        textCoin.gameObject.SetActive(false);
        textCoinEarn.gameObject.SetActive(false);
        textScore.gameObject.SetActive(false);
        textTimePlayed.gameObject.SetActive(false);

        iconCoin.gameObject.SetActive(false);
        btnReset.gameObject.SetActive(false);
        btnHome.gameObject.SetActive(false);

        money.SetMoney(resultGame.GetScore());
        topScore.SetTopScore(resultGame.GetScore());

        StartCoroutine(nameof(SetScoreCoroutine));
    }
    IEnumerator SetScoreCoroutine()
    {
        textScore.gameObject.SetActive(true);
        StartCoroutine(nameof(SetInfoCoroutine));
        while (score < resultGame.GetScore())
        {
            yield return new WaitForEndOfFrame();
            score += scoreEarn;
            textScore.text = $"SCORE: {score}";
        }
    }
    IEnumerator SetInfoCoroutine()
    {
        yield return new WaitForSeconds(.5f);
        ActiveTimePlayed();

        yield return new WaitForSeconds(1f);
        ActiveCoinEarn();
        yield return new WaitForSeconds(1f);
        ActiveCoin();

        yield return new WaitForSeconds(1.5f);
        ActiveButton(btnReset);
        yield return new WaitForSeconds(.25f);
        ActiveButton(btnHome);
    }
    void ActiveButton(Button btn)
    {
        btn.gameObject.SetActive(true);
    }
    void ActiveCoinEarn()
    {
        iconCoin.gameObject.SetActive(true);
        textCoinEarn.gameObject.SetActive(true);
        textCoinEarn.text = $"Earn: {resultGame.GetScore().ToString()} coin.";
    }
    void ActiveCoin()
    {
        textCoin.gameObject.SetActive(true);
        textCoin.text = $"Total: {money.GetMoney()} coin.";
    }
    void ActiveTimePlayed()
    {
        textTimePlayed.gameObject.SetActive(true);
        textTimePlayed.text = $"TIME PLAYED: {resultGame.GetTimePlayed()}";
    }
}
