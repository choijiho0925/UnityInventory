using System;
using UnityEngine;

public enum EquipTpye
{
    Health,
    ReactionSpeed,
    IQ,
    CodingPower
}

[Serializable]

public class EquipData
{
    public EquipTpye type;
    public float value;
}

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]

public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string itemName;
    public string itemDescription;
    public Sprite itemIcon;

    [Header("EquipData")]
    public EquipData[] equipData;
}