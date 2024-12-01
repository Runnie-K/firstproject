using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryTest : MonoBehaviour
{
    // Dictionary ����
    Dictionary<int,string> myDictionary = new Dictionary<int,string>();


    // Start is called before the first frame update
    void Start()
    {
        // �׸� �߰�
        myDictionary.Add(1, "���");
        myDictionary.Add(2, "�ٳ���");
        myDictionary.Add(3, "ü��");

        // �� ����
        string value = myDictionary[1];
        Debug.Log(value);

        // �׸� ���� ���� Ȯ��
        if (myDictionary.ContainsKey(2))
        {
            Debug.Log("key 2 ���� ������");
        }

        if (myDictionary.ContainsValue("ü��"))
        {
            Debug.Log("'ü��'��� ���� ������");

        }

        // �� ����
        myDictionary[1] = "�ƺ�ī��";

        // �׸� ����
        myDictionary.Remove(3); // Ű�� 3�� �׸� ����

        //Dictionary ��ȸ �� �� ���
        foreach(KeyValuePair<int,string> pair in myDictionary)
        {
            Debug.Log("key : " + pair.Key + ". Value : " + pair.Value);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
