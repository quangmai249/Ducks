using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "MapSelection", menuName = "ScriptsableObjects/MapSelection")]
public class MapSelection : ScriptableObject
{
    [SerializeField] private float mapCost;
    [SerializeField] private bool isOpen;
    public void SetOpen(float money)
    {
        if (money >= mapCost)
        {
            this.isOpen = true;
        }
        else this.isOpen = false;
    }
}
