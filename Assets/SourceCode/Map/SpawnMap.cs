using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnMap : MonoBehaviour
{
    public List<GameObject> ls_map;
    void Start()
    {
        string name_map = PlayerPrefs.GetString("Map");
        foreach (GameObject go in ls_map)
        {
            if (go.name == name_map)
                Instantiate(go, go.transform.position, go.transform.rotation);
        }
    }
}
