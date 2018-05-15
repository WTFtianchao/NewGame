using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VigilanceRange : MonoBehaviour {

    public Transform Cannon;
    //public static bool isCannonAngle = false;
    public Transform pointOfOrigin;

    public Action action01;
    public Action action02;

    private void Awake()
    {
        
    }

    private void Update()
    {
        if (pointOfOrigin.childCount <= 0)
        {
            action02();
            //isCannonAngle = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "EnemyTag")
        {
            Cannon.LookAt(other.transform);
            action01();
            //isCannonAngle = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "EnemyTag")
        {
            action02();
            //isCannonAngle = false;
        }
    }
}
