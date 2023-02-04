using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    

    public void PlayButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void SettingsButton()
    {

    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
