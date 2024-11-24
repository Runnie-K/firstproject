using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Enemy
{
    public override void Die()
    {
        Debug.Log("좀비가 쓰러짐");
    }
}
