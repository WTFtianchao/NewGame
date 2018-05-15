using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 2f;
        Destroy(gameObject, 6f);
    }
}
