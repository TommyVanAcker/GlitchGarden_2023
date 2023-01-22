using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 10f;
    [SerializeField] GameObject deathVFX;

    public void DealDamage(float damagePts)
    {
        health-= damagePts;
        if (health <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }

    }

    private void TriggerDeathVFX()
    {
        if (!deathVFX)
        {
            return;
        }
        GameObject deathVFXObject = Instantiate<GameObject>(deathVFX, transform.position, Quaternion.identity);
        Destroy(deathVFXObject,2f);
    }
}
