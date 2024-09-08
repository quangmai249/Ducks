using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
[CreateAssetMenu(fileName = "DataSetting", menuName = "ScriptsableObjects/Setting", order = 1)]
public class Setting : ScriptableObject
{
    [SerializeField] float _valueVolume = .5f;
    public void SetVolume(float vol)
    {
        this._valueVolume = vol;
#if UNITY_EDITOR
        EditorUtility.SetDirty(this);
#endif
    }
    public float GetVolume()
    {
        return this._valueVolume;
    }
}
