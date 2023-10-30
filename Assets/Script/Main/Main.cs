using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public Image SoundPanel;

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
        LoadingManager.sceneName = "Shop";
        SceneManager.LoadScene("Loading");
    }

    public void ClickMiniGame()
    {
        LoadingManager.sceneName = "MiniGame";
        SceneManager.LoadScene("Loading");
    }
}
