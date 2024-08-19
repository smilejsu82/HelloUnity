using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> itemGos;

    private void Awake()
    {
        Debug.Log($"<color=yellow>{itemGos.Count}</color>");

        //itemGos�� ��ȸ �ϸ鼭 �����۵��� �̸��� ����ϰ� �ʹ�.
        //����Ʈ�� ��ȸ �ϴ� ��� 
        // 1. for 
        // 2. foreach (�б� ����)
        //��� 
        //�ܰ� 
        //Ȱ 

        for (int i = 0; i < this.itemGos.Count; i++) 
        {
            //����Ʈ�� �ε����� �ش��ϴ� ����� �� ��� 
            //Debug.Log($"{i} -> {this.itemGos[i]}");

            GameObject itemGo = this.itemGos[i];
            Item item = itemGo.GetComponent<Item>();
            Debug.Log($"{item.itemName}");
        }

    }

}
