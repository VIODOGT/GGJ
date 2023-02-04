using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIStar : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    

    void Start()
    {
        text.text = "STAR 0 / 10";
    }


    void Update()
    {
        text.text = "STAR " + GameManager.Instance.currentStar + " / 10";
    }
}
