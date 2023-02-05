using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIStar : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject inGamePausePanel;
    [SerializeField] GameObject counterPanel;

    void Start()
    {
        text.text = "STAR 0 / 10";
    }


    void Update()
    {
        text.text = "STAR " + GameManager.Instance.currentStar + " / 10";
    }

    public void PauseButton()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(false);
        counterPanel.SetActive(false);
        inGamePausePanel.SetActive(true);
    }

    public void ResumeButton()
    {
        inGamePausePanel.SetActive(false);
        pausePanel.SetActive(true);
        counterPanel.SetActive(true);
        Time.timeScale = 1;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
    }

    public void QuitButton()
    {
        Application.Quit();
    }


}
