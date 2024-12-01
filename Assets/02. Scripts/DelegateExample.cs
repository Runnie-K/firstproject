using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    // 델리게이트 선언
    public delegate void MyDelegate(string message);

    // 델리게이트 참조할 메서드
    void PrintMessage(string message)
    {
        Debug.Log("프린트 메시지 함수 사용 : " +  message);
    }

    void LogMessage(string message)
    {
        Debug.Log("로그 메시지 함수 사용 : " + message);
    }

    // Start is called before the first frame update
    void Start()
    {
        //델리게이트 인스턴스 생성
        MyDelegate myDelegate = null;

        //메서드 추가
        myDelegate += PrintMessage;
        myDelegate += LogMessage;

        // 델리게이트를 사용하여 메서드 호출
        myDelegate("안녕, 멀티캐스트 델리게이트라고 해");

        // 메서드 제거 후 호출
        myDelegate -= LogMessage;
        myDelegate("로그 메시지 함수 제거하고 호출했어");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
