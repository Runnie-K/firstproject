using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEventTest : MonoBehaviour
{

    // ��������Ʈ�� �̺�Ʈ ����
    public delegate void GameOverEvent();
    public static event GameOverEvent OnGameOver;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("�÷��̾�� 'G'��ư�� ������ ���ӿ����� �˴ϴ�. ");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            TriggerGameOver();
        }
    }

    void TriggerGameOver()
    {
        Debug.Log("���� ������ �Ǿ���!!");

        if (OnGameOver != null) //OnGameOver�� ������� �ʴٸ�, �� � �Լ��� ����Ǿ� �ִٸ�
        {
            OnGameOver(); //�̺�Ʈȣ��
        }
    }
}
