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
    public Button btnPlayGame;
    public MapSelection mapSelection;
    public Money money;
    public TextMeshProUGUI textMoney;
    private void Start()
    {
        textMoney.text = money.GetMoney().ToString();
        btnPlayGame.gameObject.SetActive(false);
    }
    private void Update()
    {
        textMoney.text = money.GetMoney().ToString();
    }
    public void MapIsland()
    {
        SetMap(mapLand.First(), mapText.First());
    }
    public void MapJapanIsland()
    {
        SetMap(mapLand[1], mapText[1]);
    }
    public void MapRailwayStation()
    {
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
