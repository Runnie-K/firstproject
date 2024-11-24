using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static FirstScript;

public class Animal
{
    public void Eat()
    {
        Debug.Log("동물이 음식을 먹는다.");
    }
}


public interface IMoveable // 대문자 I를 붙히는 이유 인터페이스라는 알림 사항
{
    void Move();
}

public class Cat : Animal, IMoveable
{
    public void Move()
    {
        Debug.Log("고양이가 걸어다닙니다.");
    }
}

public class Dog : Animal, IMoveable
{
    public void Move()
    {
        Debug.Log("강아지가 걸어다닙니다.");
    }
}



public class FirstScript : MonoBehaviour
{

    void Start()
    {
        IMoveable walker = new Cat();
        walker.Move();

        walker = new Dog();
        walker.Move();
    }



    void Update()
    {

    }
}