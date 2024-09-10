using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeScreen : MonoBehaviour
{
    public GameObject panelInformation;
    public GameObject panelSetting;
    public List<Texture> textures;
    public RawImage bgHome;
    private void Start()
    {
        panelInformation.SetActive(false);
        panelSetting.SetActive(false);
        Time.timeScale = 1;
        bgHome = GameObject.Find("Background Home Screen").GetComponent<RawImage>();
        bgHome.texture = textures[RandomIndexTexture()];
    }
    int RandomIndexTexture()
    {
        return Random.Range(0, textures.Count);
    }
    public void ShowInformation()
    {
        panelInformation.SetActive(true);
    }
    public void ClosePanelInformation()
    {
        panelInformation.SetActive(false);
    }
    public void ShowPanelSetting()
    {
        panelSetting.SetActive(true);
    }
    public void ClosePanelSeting()
    {
        panelSetting.SetActive(false);
    }
}
