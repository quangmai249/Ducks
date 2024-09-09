using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SelectMap : MonoBehaviour
{
    public List<GameObject> mapLand;
    public List<TextMeshProUGUI> mapText;
    public MapSelection mapSelection;
    public Button btnPlayGame;
    private void Start()
    {
        btnPlayGame.gameObject.SetActive(false);
    }
    public void MapIsland()
    {
        //Debug.Log(mapLand[0].name);
        SetMap(mapLand.First(), mapText.First());
    }
    public void MapJapanIsland()
    {
        //Debug.Log(mapLand[1].name);
        SetMap(mapLand[1], mapText[1]);
    }
    public void MapRailwayStation()
    {
        //Debug.Log(mapLand[2].name);
        SetMap(mapLand.Last(), mapText.Last());
    }
    private void SetMap(GameObject _m, TextMeshProUGUI _t)
    {
        for (int i = 0; i < mapText.Count; i++)
        {
            mapText[i].text = mapLand[i].name;
        }
        mapSelection.SetMapSelection(_m);
        _t.text = "Selected";
        btnPlayGame.gameObject.SetActive(true);
    }
}
