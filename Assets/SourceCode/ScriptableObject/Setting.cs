using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "DataSetting", menuName = "ScriptsableObjects/Setting", order = 1)]
public class Setting : ScriptableObject
{
    [SerializeField] float _valueVolume = .5f;
    public void SetVolume(float vol)
    {
        this._valueVolume = vol;
        PlayerPrefs.SetFloat("Volume", vol);
    }
    public float GetVolume()
    {
        return PlayerPrefs.GetFloat("Volume");
    }
}
