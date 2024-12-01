using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    // ��������Ʈ ����
    public delegate void MyDelegate(string message);

    // ��������Ʈ ������ �޼���
    void PrintMessage(string message)
    {
        Debug.Log("����Ʈ �޽��� �Լ� ��� : " +  message);
    }

    void LogMessage(string message)
    {
        Debug.Log("�α� �޽��� �Լ� ��� : " + message);
    }

    // Start is called before the first frame update
    void Start()
    {
        //��������Ʈ �ν��Ͻ� ����
        MyDelegate myDelegate = null;

        //�޼��� �߰�
        myDelegate += PrintMessage;
        myDelegate += LogMessage;

        // ��������Ʈ�� ����Ͽ� �޼��� ȣ��
        myDelegate("�ȳ�, ��Ƽĳ��Ʈ ��������Ʈ��� ��");

        // �޼��� ���� �� ȣ��
        myDelegate -= LogMessage;
        myDelegate("�α� �޽��� �Լ� �����ϰ� ȣ���߾�");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
