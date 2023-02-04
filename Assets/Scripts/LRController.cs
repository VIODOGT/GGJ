using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRController : MonoBehaviour           // Bu class line çiziyor kurcalama bence
{
    private LineRenderer lineRenderer;
    private Transform[] points;
    private ArrayList pointss;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        pointss = new ArrayList();
        points = FindObjectsOfType<Transform>();
    }

    private void Start()
    {
        foreach (Transform points in pointss)
        {
            pointss.Add(points);
        }
    }

    public void SetUpLine(Transform[] points)
    {
        lineRenderer.positionCount = points.Length;
        this.points = points;
    }
    
    void Update()
    {
        for (int i = 0; i < points.Length; i++)
        {
            lineRenderer.SetPosition(i, points[i].position);
        }
    }
    
}
