using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
[CreateAssetMenu(fileName = "DataTopScore", menuName = "ScriptsableObjects/TopScore", order = 3)]
public class TopScore : ScriptableObject
{
    [SerializeField] List<int> _topScore;
    int _quantityScore = 5;
    public void SetTopScore(int score)
    {
        if (_topScore.Count > _quantityScore - 1 && score > _topScore.Min())
        {
            _topScore.Remove(_topScore.Min());
            _topScore.Add(score);
        }
        else
        {
            _topScore.Add(score);
        }
#if UNITY_EDITOR
        EditorUtility.SetDirty(this);
#endif
    }
    public List<int> GetTopScore()
    {
        for (int i = 0; i < _topScore.Count; i++)
        {
            for (int j = i + 1; j < _topScore.Count; j++)
            {
                if (_topScore[i] < _topScore[j])
                {
                    int temp = _topScore[i];
                    _topScore[i] = _topScore[j];
                    _topScore[j] = temp;
                }
            }
        }
        return _topScore;
    }
}
