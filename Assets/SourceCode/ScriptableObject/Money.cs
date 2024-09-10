using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
[CreateAssetMenu(fileName = "DataMoney", menuName = "ScriptsableObjects/Money", order = 2)]
public class Money : ScriptableObject
{
    [SerializeField] int _money;
    public void SetMoney(int m)
    {
#if UNITY_EDITOR
        this._money += m;
        EditorUtility.SetDirty(this);
#endif
    }
    public int GetMoney() { return this._money; }
}
