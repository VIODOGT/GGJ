using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject settingsPanel;

    public void PlayButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void SettingsButton()
    {
        startPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void ExitButton()
    {
        settingsPanel.SetActive(false);
        startPanel.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
