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
    [SerializeField] private Slider audioSlider;
    [SerializeField] private int sliderValue;

    void Start()
    {
        LoadValue();
    }

    private void Update()
    {
        printSaveCurrentSliderValue();
    }

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

    public void printSaveCurrentSliderValue()
    {
        float audioValue = audioSlider.value;

        PlayerPrefs.SetFloat("Volume", audioValue);

        LoadValue();

        sliderValue = Mathf.RoundToInt(audioSlider.value * 100);


    }

    public void LoadValue()
    {
        float audioValue = PlayerPrefs.GetFloat("Volume");
        audioSlider.value = audioValue;

        AudioListener.volume = audioValue;
    }
}
