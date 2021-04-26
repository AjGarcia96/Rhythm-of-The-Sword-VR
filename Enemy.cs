using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyWeapon
{
    Sword, Shield
}

public class Enemy : MonoBehaviour
{
    public EnemyWeapon weapon;

    //when collider enters another collider
    void OnTriggerEnter (Collider coll)
    {
        if(coll.CompareTag("Sword"))
        {
            if (weapon == EnemyWeapon.Sword) 
            {
                //add to score
                GameManager.instance.AddScore();
            }
            else
            {
                //subrtract health
                GameManager.instance.HitWrongEnemy();
            }
            Hit();
        }
        else if(coll.CompareTag("Shield"))
        {
            if (weapon == EnemyWeapon.Shield)
            {
                //add to score
                GameManager.instance.AddScore();
            }
            else
            {
                //subtract health
                GameManager.instance.HitWrongEnemy();
            }
            Hit();
        }
    }

    public void Hit()
    {
        // destroys the object
        Destroy(gameObject);
    }
}
