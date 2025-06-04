using System;
using UnityEngine;

public enum ItemType
{
    Consumable,
    Equipment,
}

public enum ConsumableType
{
    Speed,
    JumpForce
}

[Serializable]

public class ItemDataConsumable
{
    public ConsumableType type;
    public float value;
}

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]

public class ItemData : MonoBehaviour
{
    [Header("Info")]
    public string itemName;
    public string itemDescription;
    public Sprite itemIcon;
    public ItemType itemType;

    [Header("Stacking")]
    public bool canStack;
    public int maxStackAmount;

    [Header("Consumable")]
    public ItemDataConsumable[] consumables;
}
