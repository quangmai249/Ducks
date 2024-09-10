using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BuyMap : MonoBehaviour
{
    public Button btn;
    public Button btn_lock;
    public TextMeshProUGUI textNotify;
    public GameObject panelConfirm;
    public Money money;
    public int price = 60;
    private void Start()
    {
        btn.interactable = false;
        btn_lock.interactable = true;
        panelConfirm.SetActive(false);
        textNotify.text = price.ToString();
    }
    public void UnLock()
    {
        panelConfirm.SetActive(true);
        panelConfirm.gameObject.transform.position = btn_lock.gameObject.transform.position;
        return;
    }
    public void Confirm()
    {
        if (money.GetMoney() < price)
        {
            textNotify.text = $"You do not have enough {price}$";
            return;
        }
        else
        {
            money.SetMoney(-price);
            btn.interactable = true;
            btn_lock.gameObject.SetActive(false);
            panelConfirm.SetActive(false);
        }
    }
    public void CancelConfirm()
    {
        panelConfirm.SetActive(false);
    }
}
