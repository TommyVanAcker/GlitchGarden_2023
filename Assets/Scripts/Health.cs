using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 10f;

    public void DealDamage(float damagePts)
    {
        health-= damagePts;
        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }
}
