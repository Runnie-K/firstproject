using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    int hp = 100;

    void Start()
    {
        print("현재 나의 HP는 : " + hp + "입니다.");

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

    void Update()
    {
        if (hp > 0 && Input.GetKeyDown(KeyCode.Space))
        {
            hp = hp - 20;

            if (hp <= 0)
            {
                print("게임 오버!");
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
        }
    }
}
