using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
[CreateAssetMenu(fileName = "MapSelection", menuName = "ScriptsableObjects/MapSelection", order = 5)]
public class MapSelection : ScriptableObject
{
    [SerializeField] private GameObject map;
    public void SetMapSelection(GameObject _m)
    {
#if UNITY_EDITOR
        this.map = _m.gameObject;
        EditorUtility.SetDirty(this);
#endif
    }
    public GameObject GetMapSelection()
    {
        return this.map.gameObject;
    }
}
