using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static FirstScript;

public class FirstScript : MonoBehaviour
{
    public int[] myArray = new int[3];
    int[] myArray2 = { 3, 6, 9 };

    public List<int> myList = new List<int>();
    public List<int> myList2 = new List<int>() {3,6,9};
    /*
    public enum Fruit
    {
        APPLE,
        PEACH,
        BANANA,
        ORANGE
    }
    */
    /*
    const int DANGER_HP = 40;
    const int WARNING_HP = 60;
    const int DEAD_HP = 0;
    const int FATAL_HP = 20;
    
    int hp = 100;
    */
    void Start()
    {
        /*
        print("���� ���� HP�� : " + hp + "�Դϴ�.");
        */
        /*
        print(8 > 10); //����
        print(2 < 5); //��
        print(5 == 5); //��
        print(6 == 5); //����
        print(7 != 5); //��
        print(7 != 7); //����
        print(3 <= 5); //��
        print(3 <= 3); //��
        print(4 >= 4); //��
        print(2 >= 4); //����
        
        print(2 != 4 || 6 != 6); //��
        print(2 != 4 && 6 != 6); //����
        print(false == false); //��
        print(false != true); //��
        print(2 != 4); //��
        print(6 != 6); //����
        print(7 != 14); //��
        print(!false); //��
        */
        /*
        EnemytAttack();
        EnemytAttack();
        EnemytAttack();
        */
        /*
        print(NextYear(2024,"sunday"));
        */
        /*
        print(PlusNumber(2, 2));
        //overlord
        print(PlusNumber(2));
        print(PlusNumber(2f));
        */
        /*
        print(MinusNumber(11, 1));
        */
        /*
        print(TImesNumber(2,2));
        print(DivisonNumber(4,2));
        */

        myArray[0] = 8;
        myArray[1] = 16;
        myArray[2] = 32;

        print(myArray[1]);
        print(myList2[1]);

        myList.Add(5);
        myList.Add(10);
        myList.Insert(1,7);
        myList.Add(15);
        myList.Remove(5);
        myList.RemoveAt(1);
    }

    /*
    int thisYear;
    float pi;
    
    public string myName = "����";

    public bool isGameOver = false;

    void Start()
    {
        thisYear = 2024;
        print("�̹� ������ : " + thisYear + "�Դϴ�.");

        pi = 3.14f;
        print("���� ���� " + pi + "�Դϴ�.");

        print("���� �̸��� " + myName + "�Դϴ�.");

        if (isGameOver.Equals(true))// isGameOver�� bool type�� ���� true�� Equals(���ٸ�) ����
        {
            print("���� ���� ������ �Ǿ����� Ȯ���Ϸ���" + isGameOver + "�Դϴ�.");
        }
    }
    */

    /*
    public Fruit myFruit;
    */
    void Update()
    {
        /*
        if (Input.GetKeyUp(KeyCode.Space))
        {

            myFruit = Fruit.PEACH;

            switch (myFruit)
            {
                case Fruit.APPLE:
                    print("���");
                    break;
                case Fruit.PEACH:
                    print("������");
                    break;
                case Fruit.BANANA:
                    print("�ٳ���");
                    break;
                case Fruit.ORANGE:
                    print("������");
                    break;
            }

        }
        */
        /*
        if (hp > 0 && Input.GetKeyDown(KeyCode.Space))
        {
            hp = hp - 20;
            /*
            if (hp <= 0)
            {
                print("���� ����!");
            }
            else if (hp <= 20)
            {
                print("���� ü���� : " + hp + "�Դϴ�.");
                print("������ �������ϴ�!!!");
            }
            else if (hp <=40)
            {
                print("���� ü���� : " + hp + "�Դϴ�.");
                print("���!!!");
            }
            else if (hp <= 60)
            {
                print("����ü���� : " + hp + "�Դϴ�.");
                print("�����ϼ���!!");
            }
            else
            {
                print("���� ���� HP�� : " + hp + "�Դϴ�.");
            }
            */
        /*
            switch (hp)
            {
                case DEAD_HP:
                    print("���ӿ���");
                    break;
                case DANGER_HP:
                    print("���� ü���� : " + hp + "�Դϴ�.");
                    print("���!!!");
                    break;
                case WARNING_HP:
                    print("���� ü���� : " + hp + "�Դϴ�.");
                    print("�����ϼ���!!!");
                    break;
                case FATAL_HP:
                    print("���� ü���� : " + hp + "�Դϴ�.");
                    print("�������!!!");
                    break;
                default:
                    print("���� ü���� : " + hp + "�Դϴ�.");
                    break;

            }
        }*/

    }
    /*
    void EnemytAttack()
    {
        print("Enemty Attack");
        print("Enemty Damage");
        print("Enemty HP UI Update");
    }
    */
    /*
    int NextYear(int thisYear,string day)
    {
        int nextYear = thisYear + 1;

        return nextYear;
    }*/
    /*
    int PlusNumber(int firstNum, int secondNum)
    {
        int sum = firstNum + secondNum;
        return sum;
    }
    int PlusNumber(int firstNum)
    {
        int sum = firstNum + 3;
        return sum;
    }
    float PlusNumber(float firstNum)
    {
        float sum = firstNum + 3;
        return sum;
    }
    */
    /*
    int MinusNumber (int firstNum, int secondNum)
    {
        int sum = firstNum - secondNum;
        return sum;
    }
    */
    /*
    int TImesNumber (int firstNum, int secondNum) 
    {
        int sum = firstNum * secondNum;
        return sum; 
    }
    int DivisonNumber(int firstNum, int secondNum)
    {
        int sum = firstNum / secondNum;
        return sum; 
    }
    */
}
