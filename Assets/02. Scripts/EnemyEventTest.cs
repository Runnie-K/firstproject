using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEventTest : MonoBehaviour
{
    private void OnEnable()
    {
        //�̺�Ʈ ����
        PlayerEventTest.OnGameOver += RespondToGameOver;
    }

    private void OnDisable()
    {
        PlayerEventTest.OnGameOver -= RespondToGameOver;
    }

    void RespondToGameOver()
    {
        Debug.Log("���� " + this.gameObject.name + "�÷��̾ �׾���?, ���� �ٽ� �� �� �Ϸ� ������� ����ؾ���.");
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
