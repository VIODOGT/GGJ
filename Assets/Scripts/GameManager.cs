using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject Asteroid;
    [SerializeField] Transform parentObject;


    private void Start()
    {
        SpawnRandomAsteroid();
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
