using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    int hp = 100;

    void Start()
    {
        print("���� ���� HP�� : " + hp + "�Դϴ�.");

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

    void Update()
    {
        if (hp > 0 && Input.GetKeyDown(KeyCode.Space))
        {
            hp = hp - 20;

            if (hp <= 0)
            {
                print("���� ����!");
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
        }
    }
}
