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
        this._money += m;
#if UNITY_EDITOR
        EditorUtility.SetDirty(this);
        //AssetDatabase.SaveAssets();
#endif
    }
    public int GetMoney() { return this._money; }
}
