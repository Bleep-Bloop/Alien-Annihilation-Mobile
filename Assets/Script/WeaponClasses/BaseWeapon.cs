using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseWeapon : MonoBehaviour
{

    [SerializeField] protected float timeBetweenAttacks = 1;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        // Sets the weapon to be fired every timeBetweenAttacks
        InvokeRepeating("Attack", timeBetweenAttacks, timeBetweenAttacks);
    }

    protected void ChangeTimeBetweenAttacks(float newTimeBetweenAttacks)
    {
        CancelInvoke();
        InvokeRepeating("Attack", newTimeBetweenAttacks, newTimeBetweenAttacks);
    }

    /// <summary>
    /// Uses the weapon.
    /// Automatically called every timeBetweenAttacks.
    /// </summary>
    protected abstract void Attack();
    
}
