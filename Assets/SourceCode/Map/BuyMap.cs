using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuyMap : MonoBehaviour
{
    public TextMeshProUGUI textMoney;
    public TextMeshProUGUI textConfirm;
    public RawImage imgConfirm;
    public Money money;
    private void Start()
    {
        textMoney.text = money.GetMoney().ToString();
        textConfirm.gameObject.SetActive(false);
        imgConfirm.gameObject.SetActive(false);
    }
    public void ClickToConfirm()
    {
        textConfirm.gameObject.SetActive(true);
        textConfirm.text = $"{money.GetMoney() - 100}";
    }
    public void ClickToBuy()
    {
        imgConfirm.gameObject.SetActive(true);
    }
    public void CancelBuying()
    {
        imgConfirm.gameObject.SetActive(false);
    }
}
