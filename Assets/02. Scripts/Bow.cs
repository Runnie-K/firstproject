using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : Weapon
{
    public override void Attack()
    {
        Debug.Log("Arrow shot");
    }
}