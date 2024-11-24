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
        Debug.Log("������ ������ �Դ´�.");
    }
}


public interface IMoveable // �빮�� I�� ������ ���� �������̽���� �˸� ����
{
    void Move();
}

public class Cat : Animal, IMoveable
{
    public void Move()
    {
        Debug.Log("����̰� �ɾ�ٴմϴ�.");
    }
}

public class Dog : Animal, IMoveable
{
    public void Move()
    {
        Debug.Log("�������� �ɾ�ٴմϴ�.");
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