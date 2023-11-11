using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public Image SoundPanel;
    public Image ShopPanel;
    public Image InventoryPanel;

    public void ClickBack()
    {
        LoadingManager.sceneName = "Start";
        SceneManager.LoadScene("Loading");
    }
    
    public void ClickSound()
    {
        SoundPanel.gameObject.SetActive(true);
    }

    public void ClickClose()
    {
        SoundPanel.gameObject.SetActive(false);
    }

    public void ClickShop()
    {
        ShopPanel.gameObject.SetActive(true);
        InventoryPanel.gameObject.SetActive(true);
    }

    public void ClickMiniGame()
    {
        LoadingManager.sceneName = "MiniGame";
        SceneManager.LoadScene("Loading");
    }

    public void ClickEarth()
    {
        LoadingManager.sceneName = "Continent";
        SceneManager.LoadScene("Loading");
    }

    public void ClickShopClose()
    {
        ShopPanel.gameObject.SetActive(false);
        InventoryPanel.gameObject.SetActive(false);
    }

    public void ClickTree()
    {
        LoadingManager.sceneName = "Tree";
        SceneManager.LoadScene("Loading");
    }
}
