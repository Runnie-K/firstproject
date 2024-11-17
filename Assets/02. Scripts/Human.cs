using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    public string myName;
    int myAge;
    float myHeight;
    bool isSolo;

    public void Eat()
    {
        print("eat");
    }

    public void Sleep()
    {
        print("sleep");
    }

    public void PowerPush()
    {
        print("Power Push");
    }
}
