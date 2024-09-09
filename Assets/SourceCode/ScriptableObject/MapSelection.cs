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
        this.map = _m.gameObject;
#if UNITY_EDITOR
        EditorUtility.SetDirty(this);
#endif
    }
    public GameObject GetMapSelection()
    {
        return this.map.gameObject;
    }
}
