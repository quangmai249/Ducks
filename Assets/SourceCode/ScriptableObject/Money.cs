using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "DataMoney", menuName = "ScriptsableObjects/Money", order = 2)]
public class Money : ScriptableObject
{
    [SerializeField] int _money;
    public void SetMoney(int m)
    {
        this._money = PlayerPrefs.GetInt("Money");
        PlayerPrefs.SetInt("Money", this._money += m);
    }
    public int GetMoney()
    {
        return PlayerPrefs.GetInt("Money");
    }
}
