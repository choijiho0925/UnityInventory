using UnityEngine;

public class ConditionController : MonoBehaviour
{
    public ItemData equipItem;
    public ItemData beforeItem;

    public void CheckItem()
    {
        if (beforeItem != null)
        {
            switch (beforeItem.equipData[0].type)
            {
                case EquipTpye.Health: 
                        GameManager.Instance.Player.condition.Health -= (int)beforeItem.equipData[0].value; 
                break;
                case EquipTpye.ReactionSpeed: 
                        GameManager.Instance.Player.condition.ReactionSpeed -= (int)beforeItem.equipData[0].value; 
                break;
                case EquipTpye.IQ: 
                        GameManager.Instance.Player.condition.IQLevel -= (int)beforeItem.equipData[0].value;
                break;
                case EquipTpye.CodingPower: 
                        GameManager.Instance.Player.condition.CodingPower -= (int)beforeItem.equipData[0].value; 
                break;
            }
        }

        if (equipItem != null)
        {
            switch (equipItem.equipData[0].type)
            {
                case EquipTpye.Health: 
                        GameManager.Instance.Player.condition.Health += (int)equipItem.equipData[0].value; 
                break;
                case EquipTpye.ReactionSpeed: 
                        GameManager.Instance.Player.condition.ReactionSpeed += (int)equipItem.equipData[0].value; 
                break;
                case EquipTpye.IQ: 
                        GameManager.Instance.Player.condition.IQLevel += (int)equipItem.equipData[0].value; 
                break;
                case EquipTpye.CodingPower: 
                        GameManager.Instance.Player.condition.CodingPower += (int)equipItem.equipData[0].value; 
                break;
            }

            beforeItem = equipItem;
        }
        else
        {
            beforeItem = null;
        }
    }
}