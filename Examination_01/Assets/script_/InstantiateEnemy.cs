using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateEnemy : MonoBehaviour {

    public GameObject Enemy;
    float InstantiateTime = 0;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        InstantiateTime += Time.deltaTime;
        if (InstantiateTime > 0.5f && Input.GetMouseButton(0))
        {
            InstantiateTime = 0;
            Instantiate(Enemy, transform.position, Quaternion.identity,transform);
        }
    }
}
