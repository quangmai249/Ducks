using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMap : MonoBehaviour
{
    public List<GameObject> mapLand;
    void Start()
    {
        Instantiate(mapLand[RandomMap()], mapLand[RandomMap()].transform.position, mapLand[RandomMap()].transform.rotation);
    }
    int RandomMap()
    {
        return Random.Range(0, mapLand.Count);
    }
}
