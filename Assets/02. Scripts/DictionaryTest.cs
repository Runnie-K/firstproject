using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryTest : MonoBehaviour
{
    // Dictionary 생성
    Dictionary<int,string> myDictionary = new Dictionary<int,string>();


    // Start is called before the first frame update
    void Start()
    {
        // 항목 추가
        myDictionary.Add(1, "사과");
        myDictionary.Add(2, "바나나");
        myDictionary.Add(3, "체리");

        // 값 접근
        string value = myDictionary[1];
        Debug.Log(value);

        // 항목 존재 여부 확인
        if (myDictionary.ContainsKey(2))
        {
            Debug.Log("key 2 값이 존재함");
        }

        if (myDictionary.ContainsValue("체리"))
        {
            Debug.Log("'체리'라는 값이 존재함");

        }

        // 값 변경
        myDictionary[1] = "아보카도";

        // 항목 제거
        myDictionary.Remove(3); // 키가 3인 항목 제거

        //Dictionary 순회 및 값 출력
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
