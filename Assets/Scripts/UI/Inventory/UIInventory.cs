using TMPro;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    [SerializeField] ItemSlot[] itemSlots;

    [SerializeField] GameObject uiInventory;
    [SerializeField] Transform slotPanel;

    [Header("Selected Item")]
    [SerializeField] TextMeshProUGUI selectedItemName;


    public void Open()
    {
        uiInventory.SetActive(true);
    }

    public void Close()
    {
        uiInventory.SetActive(false);
    }
}