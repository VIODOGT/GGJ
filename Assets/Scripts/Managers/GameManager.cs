using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject Asteroid;
    [SerializeField] Transform parentObject;
    public int currentStar;
    public static GameManager Instance;
    private MainStarController mainstar;
    [SerializeField] private GameObject TurnRootPanel;
    [SerializeField] GameObject finishPanel;
    [SerializeField]public TimeScaleFader timeScaleFader;

    private void Awake()
    {
        timeScaleFader = GetComponent<TimeScaleFader>();
        if (Instance == null)
        {
            Instance = this;
        }
    }


    private void Start()
    {
        mainstar = GetComponent<MainStarController>();

        SpawnRandomAsteroid();     
    }

    private void Update()
    {
        FinishGame();
    }

    void SpawnRandomAsteroid()
    {
        for (int i = 0; i < 1000; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-200, 400), Random.Range(60,350), Random.Range(-200, 600));
            Instantiate(Asteroid, spawnPosition, Quaternion.identity, parentObject);
        }
    }

    void FinishGame()
    {
        if (currentStar == 10)
        {
            OpenTurnRootPanel();

        }
    }

    public void OpenTurnRootPanel()
    {
        TurnRootPanel.SetActive(true);

    }
    public void CloseTurnRootPanel()
    {
        TurnRootPanel.SetActive(false);

    }

    public void openFinishPanel()
    {
        finishPanel.SetActive(true);
        timeScaleFader.FadeOut();
    }

}
