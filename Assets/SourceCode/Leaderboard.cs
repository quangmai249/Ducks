using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Leaderboard : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textScoreOutTop;
    public TopScore topScore;
    void Start()
    {
        textScoreOutTop.text = "";
        for (int i = 0; i < topScore.GetTopScore().Count; i++)
            textScoreOutTop.text += $"Top {i + 1} :\t\t{topScore.GetTopScore()[i]}\n";
    }
}