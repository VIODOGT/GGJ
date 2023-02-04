using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStarController : MonoBehaviour // Bu Class 2 Yıldız Etkinleştirdikten sonra Main Yıldıza da Gidilebilmeyi Açıyor
{
    private void OpenPlayerCatcherForMainStar()
    {
        int interactedStarAmount = Camera.main.GetComponent<LRRender>().points.Length; //
        if (interactedStarAmount >= 3)
        {
            GetComponent<PlayerCatcher>().enabled = true;
            GetComponent<Star>().enabled = true;
        }
    }
    void Update()
    {
        OpenPlayerCatcherForMainStar();
    }
}
