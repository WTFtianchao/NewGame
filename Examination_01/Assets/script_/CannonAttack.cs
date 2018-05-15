using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonAttack : MonoBehaviour {

    public Transform Fire;
    public GameObject Bullet;
    public Collider vigilanceRange;

    Quaternion CannonAngle;
    GameObject BulletObj;
    float BulletTime;

    private void Awake()
    {
        CannonAngle = transform.rotation;
        vigilanceRange.GetComponent<VigilanceRange>().action01 = Attack;
        vigilanceRange.GetComponent<VigilanceRange>().action02 = BuAttack;
    }

    void Update () {

	}

    void Attack()
    {
        BulletTime += Time.deltaTime;
        if (BulletTime > 1f)
        {
            BulletTime = 0;
            BulletObj= Instantiate(Bullet, Fire.position, Fire.rotation);
            BulletObj.name = "Bullet";
        }
    }
    void BuAttack()
    {
        transform.rotation = CannonAngle;
    }
}
