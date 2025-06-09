using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButton : MonoBehaviour
{
    public ItemData[] itemData;

    public void GetItem()
    {
        int randomIndex = Random.Range(0, itemData.Length);
        ItemData randomItem = itemData[randomIndex];

        UIInventory inventory = FindObjectOfType<UIInventory>();
        inventory.AddItem(randomItem);
        UIManager.Instance.Inventory.CurrentCount ++;
        UIManager.Instance.Inventory.UPdateCurrentSlotCount();
    }
}
