using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShooterScript : MonoBehaviour
{
    public Transform firepoint;
    public GameObject arrow;
    float timeBetween;
    public float startTimeBetween;

    public List<GameObject> arrows = new List<GameObject>();

    void Start()
    {
        timeBetween = startTimeBetween;
    }

    void Update()
    {
        if(timeBetween <= 0) 
        {
            SpawnArrow();
            timeBetween = startTimeBetween;
        }
        else
        {
            timeBetween -= Time.deltaTime;
        }
    }

    void SpawnArrow()
    {
        GameObject instance = Instantiate(arrow, firepoint.position, firepoint.rotation);
        instance.name = "arrow1";
        arrows.Add(instance);
    }

    public void DestroyAllArrows()
    {
        foreach (GameObject arrow1 in arrows)
        {
            Destroy(arrow1);
        }
    }
}
