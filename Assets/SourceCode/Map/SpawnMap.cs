using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMap : MonoBehaviour
{
    public MapSelection mapSelection;
    void Start()
    {
        if (mapSelection != null)
            Instantiate(mapSelection.GetMapSelection()
            , mapSelection.GetMapSelection().transform.position
            , mapSelection.GetMapSelection().transform.rotation);
        else
            return;
    }
}
