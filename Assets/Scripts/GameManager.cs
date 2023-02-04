using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject Asteroid;
    [SerializeField] Transform parentObject;
    public int currentStar;
    public static GameManager Instance;
    private MainStarController mainstar;

    private void Awake()
    {
        if(Instance == null)
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
    }

    void SpawnRandomAsteroid()
    {
        for (int i = 0; i < 1000; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-200, 400), Random.Range(60,350), Random.Range(-200, 600));
            Instantiate(Asteroid, spawnPosition, Quaternion.identity, parentObject);
        }
    }



}
