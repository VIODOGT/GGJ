using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Star : MonoBehaviour
{
    [SerializeField] public StarState state;
    [SerializeField] private Material[] materials;
    [SerializeField] private ParticleSystem pS1;
    [SerializeField] private ParticleSystem pS2;
    [SerializeField] private ParticleSystem pS3;
    [HideInInspector] public float loadingPoint;
    private MeshRenderer renderer;
    public bool isInteracted;

    private void Start()
    {
        GetComponent<MeshRenderer>().material = materials[0];       // Yıldızların etkileşime geçilmiş ve geçilmemiş materialleri
        loadingPoint = 0f;
    }

    private void Update()
    {
        StateCheck();
    }

    // ReSharper disable Unity.PerformanceAnalysis
    public void StateCheck()                // Etkileşime geçilmiş mi kontrol
    {
        if (state == StarState.Interacted)
        {
            GetComponent<MeshRenderer>().material = materials[1];
            isInteracted = true;
        }
        else
        {
            GetComponent<MeshRenderer>().material = materials[0];
            isInteracted = false;
        }
    }

    public void PlayParticle()    
    {
        pS1.Play();
        pS2.Play();
        pS3.Play();
    }

    public float IncreaseLoadingPoint()        // E'ye basarak doldurduğumuz çemberin artırma fonksiyonu
    {
        return loadingPoint += 0.5f * Time.deltaTime;
    }
}
