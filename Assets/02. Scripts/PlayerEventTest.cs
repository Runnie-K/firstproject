using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEventTest : MonoBehaviour
{

    // 델리게이트와 이벤트 선언
    public delegate void GameOverEvent();
    public static event GameOverEvent OnGameOver;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("플레이어는 'G'버튼을 누르면 게임오버가 됩니다. ");

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
        Debug.Log("게임 오버가 되었어!!");

        if (OnGameOver != null) //OnGameOver가 비어있지 않다면, 즉 어떤 함수가 연결되어 있다면
        {
            OnGameOver(); //이벤트호출
        }
    }
}
