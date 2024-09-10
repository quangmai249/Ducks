using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "DataMoney", menuName = "ScriptsableObjects/Money", order = 2)]
public class Money : ScriptableObject
{
    [SerializeField] int _money;
    int _amount;
    public void SetMoney(int m)
    {
        this._money += m;
        _amount = PlayerPrefs.GetInt("Money");
        PlayerPrefs.SetInt("Money", _amount += m);
    }
    public int GetMoney()
    {
        return PlayerPrefs.GetInt("Money");
    }
}
