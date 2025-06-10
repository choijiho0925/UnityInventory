using UnityEngine;

public class Character : MonoBehaviour
{
    public Condition condition;
    public Controller controller;
    public ConditionController conditionController;

    public string NickName { get; private set; }
    public string ID { get; private set; }
    public string Description { get; private set; }
    public string Level { get; private set; }

    public void SetData(string nickname, string id, string level, string description)
    {
        NickName = nickname;
        ID = id;
        Level = level;
        Description = description;
    }

    private void Equip(ItemSlot slot)
    {
        if (slot.data == null)
        {
            return;
        }
        else
        {
            foreach (var itemSlot in UIManager.Instance.Inventory.GetAllSlots())
            {
                itemSlot.Equipped = false;
                itemSlot.OnEnable();
            }
            slot.Equipped = true;
            slot.OnEnable();
            GameManager.Instance.Player.conditionController.equipItem = slot.data;
        }
    }

    private void UnEquip(ItemSlot slot)
    {
        slot.Equipped = false;
        slot.OnEnable();
        GameManager.Instance.Player.conditionController.equipItem = null;
    }

    public void EquipTool(ItemSlot slot)
    {
        if (slot.Equipped)
        {
            UnEquip(slot);
        }
        else
        {
            Equip(slot);
        }
    }
}