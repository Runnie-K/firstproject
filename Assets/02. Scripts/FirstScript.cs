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
        print("현재 나의 HP는 : " + hp + "입니다.");
        */
        /*
        print(8 > 10); //거짓
        print(2 < 5); //참
        print(5 == 5); //참
        print(6 == 5); //거짓
        print(7 != 5); //참
        print(7 != 7); //거짓
        print(3 <= 5); //참
        print(3 <= 3); //참
        print(4 >= 4); //참
        print(2 >= 4); //거짓
        
        print(2 != 4 || 6 != 6); //참
        print(2 != 4 && 6 != 6); //거짓
        print(false == false); //참
        print(false != true); //참
        print(2 != 4); //참
        print(6 != 6); //거짓
        print(7 != 14); //참
        print(!false); //참
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
    
    public string myName = "민중";

    public bool isGameOver = false;

    void Start()
    {
        thisYear = 2024;
        print("이번 연도는 : " + thisYear + "입니다.");

        pi = 3.14f;
        print("파이 값은 " + pi + "입니다.");

        print("나의 이름은 " + myName + "입니다.");

        if (isGameOver.Equals(true))// isGameOver가 bool type의 값이 true와 Equals(같다면) 실행
        {
            print("현재 게임 오버가 되었는지 확인하려면" + isGameOver + "입니다.");
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
                    print("사과");
                    break;
                case Fruit.PEACH:
                    print("복숭아");
                    break;
                case Fruit.BANANA:
                    print("바나나");
                    break;
                case Fruit.ORANGE:
                    print("오랜지");
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
                print("게임 오버!");
            }
            else if (hp <= 20)
            {
                print("현재 체력은 : " + hp + "입니다.");
                print("죽음이 가깝습니다!!!");
            }
            else if (hp <=40)
            {
                print("현재 체력은 : " + hp + "입니다.");
                print("비상!!!");
            }
            else if (hp <= 60)
            {
                print("현재체력은 : " + hp + "입니다.");
                print("조심하세요!!");
            }
            else
            {
                print("현재 나의 HP는 : " + hp + "입니다.");
            }
            */
        /*
            switch (hp)
            {
                case DEAD_HP:
                    print("게임오버");
                    break;
                case DANGER_HP:
                    print("현재 체력은 : " + hp + "입니다.");
                    print("비상!!!");
                    break;
                case WARNING_HP:
                    print("현재 체력은 : " + hp + "입니다.");
                    print("조심하세요!!!");
                    break;
                case FATAL_HP:
                    print("현재 체력은 : " + hp + "입니다.");
                    print("사망직전!!!");
                    break;
                default:
                    print("현재 체력은 : " + hp + "입니다.");
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
