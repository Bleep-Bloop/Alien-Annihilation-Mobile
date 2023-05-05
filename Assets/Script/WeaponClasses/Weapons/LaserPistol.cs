using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class LaserPistol : BaseWeapon
{

    [SerializeField] private float attackRange = 5;
    [SerializeField] private LayerMask enemyLayer;
    
    private Transform targetTransform = null;

    protected override void Start()
    {
        base.Start();
    }

    protected override void Attack()
    {
        Debug.Log("LaserPistol::Attack");
       
        if(targetTransform = TargetClosestInsideLayer(enemyLayer, attackRange))
            Debug.Log(("Closest Target Transform(x,y): %f, %f ", targetTransform.transform.position.x, targetTransform.transform.position.y));
   
    }

    /// <summary>
    /// Casts a circle around GameObject and returns the Transform of the closest hit object inside given TargetLayerMask.
    /// </summary>
    /// <param name="targetLayerMask">Layer holding targettable objects</param>
    /// <param name="targetRadius">Radius of targetting zone</param>
    /// <returns>Transform of closest object inside targettable layer</returns>
    private Transform TargetClosestInsideLayer(LayerMask targetLayerMask, float targetRadius)
    {

        RaycastHit2D[] hits;
        hits = Physics2D.CircleCastAll(transform.position, targetRadius, Vector2.zero, 0, targetLayerMask);

        // Order the hits array by closest distance (CircleCastAll does not guarentee proper order).
        hits = hits.OrderBy(x => Vector2.Distance(this.transform.position, x.transform.position)).ToArray();

        // If a target is in range
        if (hits.Length > 0)
            return hits[0].transform;
        else
            return null;

    }

}
