using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
[CreateAssetMenu(fileName = "DataTopScore", menuName = "ScriptsableObjects/TopScore", order = 3)]
public class TopScore : ScriptableObject
{
    [SerializeField] int _topScore;
    public void SetTopScore(int score)
    {
        if (_topScore < score)
            this._topScore = score;
        PlayerPrefs.SetInt("TopScore", this._topScore);
    }
    public int GetTopScore()
    {
        return PlayerPrefs.GetInt("TopScore");
    }
}
