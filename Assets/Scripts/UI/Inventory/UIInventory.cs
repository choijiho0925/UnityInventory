using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class UIInventory : MonoBehaviour
{
    [SerializeField] ItemSlot[] itemSlots;

    [SerializeField] GameObject uiInventory;

    [Header("Slot Option")]
    [SerializeField] int slotCount;
    [SerializeField] Transform slotPanel;
    [SerializeField] GameObject itemSlotPrefab;

    [Header("Inventory UI")]
    [SerializeField] TextMeshProUGUI totalSlotCount;
    public TextMeshProUGUI currentSlotCount;

    private List<ItemSlot> items = new List<ItemSlot>();
    private int currentCount;
    public int CurrentCount { get { return currentCount; } set { currentCount = value; } }

    private void Start()
    {
        InitSlots();
    }

    private void InitSlots()
    {
        for (int i = 0; i < slotCount; i++)
        {
            GameObject slotObj = Instantiate(itemSlotPrefab, slotPanel);
            ItemSlot slot = slotObj.GetComponent<ItemSlot>();
            slotObj.name = $"ItemSlot_{i + 1}";
            items.Add(slot);
        }

        SetTotalText();
    }

    public void AddItem(ItemData itemData)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].data == null)
            {
                items[i].SetData(itemData);
                return;
            }
            else
            {
                Debug.Log("End");
            }
        }
    }

    public List<ItemSlot> GetAllSlots()
    {
        return items;
    }

    private void SetTotalText()
    {
        totalSlotCount.text = $"/ {slotCount}";
    }

    public void UPdateCurrentSlotCount()
    {
        currentSlotCount.text = $"{currentCount}";
    }

    public void Open()
    {
        uiInventory.SetActive(true);
    }

    public void Close()
    {
        uiInventory.SetActive(false);
    }
}