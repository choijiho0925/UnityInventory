using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

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

    private List<ItemSlot> items = new List<ItemSlot>();

    private void Start()
    {
        InitSlots();
    }

    private void Update()
    {
        
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

        totalSlotCount.text = $"/ {slotCount}";
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