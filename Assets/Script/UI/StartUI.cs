using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartUI : MonoBehaviour
{
    public Image SoundPanel;
    public Image CallPanel;
    public void ClickSoundButton()
    {
        SoundPanel.gameObject.SetActive(true);
    }

    public void ClickClose()
    {
        SoundPanel.gameObject.SetActive(false);
    }

    public void ClickBGMON()
    {
        Debug.Log("BGM ON");
    }

    public void ClickBGMOFF()
    {
        Debug.Log("BGM OFF");
    }

    public void ClickSoundON()
    {
        Debug.Log("Sound ON");
    }

    public void ClickSoundOFF()
    {
        Debug.Log("Sound OFF");
    }

    public void ClickStart()
    {
        Debug.Log("Start");
        LoadingManager.sceneName = "Stroy";
        SceneManager.LoadScene("Loading");
    }

    public void ClickCall()
    {
        CallPanel.gameObject.SetActive(true);
    }

    public void ClickCloseCall()
    {
        CallPanel.gameObject.SetActive(false);
    }
}
