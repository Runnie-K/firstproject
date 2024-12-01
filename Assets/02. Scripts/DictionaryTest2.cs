using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryTest2 : MonoBehaviour
{
    // Dictionary 생성
    Dictionary<string, int> items = new Dictionary<string, int>();

    // Start is called before the first frame update
    void Start()
    {
        //아이템 추가
        AddItem("포션", 5);
        AddItem("엘릭서", 2);

        //아이템 사용
        UseItem("포션");

        //아이템 인벤토리 출력
        PrintInventory();
    }

    // Update is called once per frame
    void AddItem(string itemName, int quantity)
    {
        if (items.ContainsKey(itemName))
        {
            items[itemName] = quantity;
        }
        else
        {
            items.Add(itemName, quantity);
        }
        Debug.Log("추가 " + quantity + " " + itemName + "(을)인벤토리로");
    }

    void UseItem(string itemName)
    {
        if (items.ContainsKey(itemName))
        {
            items[itemName]--;
            if (items[itemName] <= 0)
            {
                items.Remove(itemName);
            }
            Debug.Log("사용한 아이템 : " + itemName + ".");
        }
        else
        {
            Debug.Log("아이템 " + itemName + "을 인벤토리에서 찾을 수 없음");
        }
    }

    void PrintInventory()
    {
        foreach (KeyValuePair<string, int> item in items)
        {
            Debug.Log("아이템 : " + item.Key + " , 수량 : " + item.Value);
        }
    }
}
