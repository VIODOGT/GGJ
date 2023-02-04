using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStarController : MonoBehaviour // Bu Class 2 Yıldız Etkinleştirdikten sonra Main Yıldıza da Gidilebilmeyi Açıyor
{
    private int interactedStarAmount;
    public bool isInteractedMainStar;

    private void Start()
    {
        isInteractedMainStar = false;
    }
    private void OpenPlayerCatcherForMainStar()
    {
        interactedStarAmount = Camera.main.GetComponent<LRRender>().points.Length; 
        if (interactedStarAmount >= 3)
        {
            if(GameManager.Instance.currentStar >= 10)
            {
                GetComponent<PlayerCatcher>().enabled = true;
                GetComponent<Star>().enabled = true;
     
            }
        }
    }
    void Update()
    {
        OpenPlayerCatcherForMainStar();  
    }
}
