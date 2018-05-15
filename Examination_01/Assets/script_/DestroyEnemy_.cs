using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy_ : MonoBehaviour {

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "EnemyTag")
        {
            Destroy(other.gameObject);
        }
    }
}
