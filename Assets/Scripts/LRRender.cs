using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class LRRender : MonoBehaviour     // bunu da kurcalama 
{
    public Transform[] points;
    public LRController lrController;
    void Start()
    {
        lrController.SetUpLine(points);
    }

    public void SetUpLine(Transform point)
    {
        Array.Resize(ref points, points.Length + 1);
        points[points.Length - 1] = point;
        //points[points.Length - 1] = point;

        lrController.SetUpLine(points);
    }
}
