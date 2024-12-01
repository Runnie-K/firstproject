using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEventTest : MonoBehaviour
{
    private void OnEnable()
    {
        //이벤트 구독
        PlayerEventTest.OnGameOver += RespondToGameOver;
    }

    private void OnDisable()
    {
        PlayerEventTest.OnGameOver -= RespondToGameOver;
    }

    void RespondToGameOver()
    {
        Debug.Log("나는 " + this.gameObject.name + "플레이어가 죽었네?, 나는 다시 할 일 하러 흩어져서 대기해야지.");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
