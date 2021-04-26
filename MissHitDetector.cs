using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissHitDetector : MonoBehaviour
{
    void OnTriggerEnter (Collider coll)
    {
        if (coll.CompareTag("Enemy"))
        {
            coll.GetComponent<Enemy>().Hit();
            GameManager.instance.MissEnemy();

        }
    }
}
