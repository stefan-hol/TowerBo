using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemieLevens : LevensComponent
{ 
    protected override void Death()
    {
        base.Death();
        Destroy(gameObject);
    }
}
