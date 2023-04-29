using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPistol : BaseWeapon
{
    protected override void Attack()
    {
        Debug.Log("LaserPistol::Attack");
    }

    protected override void Start()
    {
        base.Start();
    }

}
