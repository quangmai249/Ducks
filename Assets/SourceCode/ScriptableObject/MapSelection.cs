using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "MapSelection", menuName = "ScriptsableObjects/MapSelection", order = 5)]
public class MapSelection : ScriptableObject
{
    [SerializeField] private GameObject map;
    public void SetMapSelection(GameObject _m)
    {
        this.map = _m.gameObject;
        PlayerPrefs.SetString("Map", this.map.name);
    }
}
