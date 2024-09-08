using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI textHighestScore;
    public TextMeshProUGUI textcountdownStartGame;

    public ParticleSystem parFirework;

    public GameObject panelGameOver;
    public GameObject panelPause;
    public GameObject panelCountDownStartGame;

    public ResultGame resultGame;
    public TopScore topScore;

    public int heart = 3;

    public bool isGameOver;
    public bool isGameStart;
    public bool isGamePause;

    public float timeToPlayed;
    public float timeCountdownStartGame = 3f;

    //[SerializeField] float timeLeft = 60f;

    [SerializeField] int score;
    [SerializeField] int scoreEarn = 10;
    [SerializeField] string timeToPlayedString;
    private void Start()
    {
        isGameOver = false;
        isGameStart = false;
        isGamePause = false;

        Time.timeScale = 1;

        panelGameOver = GameObject.FindGameObjectWithTag("PanelGameOver");
        panelGameOver.SetActive(false);

        panelPause = GameObject.FindGameObjectWithTag("PanelPause");
        panelPause.SetActive(false);

        panelCountDownStartGame = GameObject.FindGameObjectWithTag("PanelCountdownStartGame");
        panelCountDownStartGame.SetActive(true);

        if (topScore.GetTopScore().Count > 0)
            textHighestScore.text = $"Highest Score: {topScore.GetTopScore().Max()}";
        else textHighestScore.text = $"Highest Score: 0";

        StartCoroutine(nameof(CoroutineCountDownStartGame));
    }
    private void Update()
    {
        Countdown();
        SetTextTimerScore();

        timeToPlayedString = TimeSpan.FromSeconds(timeToPlayed).ToString();

        if (isGameOver == true)
        {
            resultGame.SetResultGamePlay(score, timeToPlayedString.Substring(0, 8));
            GameOver();
        }
    }
    IEnumerator CoroutineCountDownStartGame()
    {
        yield return new WaitForSeconds(timeCountdownStartGame + 1);
        panelCountDownStartGame.SetActive(false);
        isGameStart = true;
    }
    public void SetScore()
    {
        StartCoroutine(nameof(SetScoreCoroutine));
    }
    IEnumerator SetScoreCoroutine()
    {
        for (int i = 0; i < scoreEarn; i++)
        {
            yield return new WaitForEndOfFrame();
            score += 1;
        }
    }
    void Countdown()
    {
        timeCountdownStartGame -= Time.deltaTime;
        if (Mathf.Round(timeCountdownStartGame) <= 0)
            textcountdownStartGame.text = $"LET'S GO!!!";
        else textcountdownStartGame.text = $"{Mathf.Round(timeCountdownStartGame)}";
    }
    void SetTextTimerScore()
    {
        if (isGameStart == true)
        {
            timeToPlayed += Time.deltaTime;
            //timeLeft -= Time.deltaTime;
            //textTimer.text = $"{Mathf.Round(timeLeft)}s";
            textScore.text = $"SCORE: {score}";

            if (heart == 0)
                GameOver();

            //if (timeLeft < 0)
            //{
            //    isGameOver = true;
            //    GameOver();
            //}
        }
    }
    void GameOver()
    {
        isGameOver = true;
        StartCoroutine(nameof(LoadSceneGameOver));
    }
    IEnumerator LoadSceneGameOver()
    {
        panelGameOver.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }

    //Setting
    public void Pause()
    {
        isGamePause = true;
        panelPause.SetActive(true);
        Time.timeScale = 0;
    }
    public void Resume()
    {
        isGamePause = false;
        panelPause.SetActive(false);
        Time.timeScale = 1;
    }
}
