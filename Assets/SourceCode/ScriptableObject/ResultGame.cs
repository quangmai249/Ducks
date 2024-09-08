using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "DataResultGame", menuName = "ScriptableObjects/ResultGame", order = 4)]
public class ResultGame : ScriptableObject
{
    [SerializeField] int score;
    [SerializeField] string timePlayed;
    public void SetResultGamePlay(int score, string timePlayed)
    {
        this.score = score;
        this.timePlayed = timePlayed;
    }
    public int GetScore() { return score; }
    public string GetTimePlayed() { return timePlayed; }
}
