using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] Image icon;
    [SerializeField] TextMeshProUGUI amountText;
    [SerializeField] GameObject equipText;

    [SerializeField] ItemData itemData;

    private int amount;
    private bool equipped;
    public bool Equipped { get { return equipped; } set { equipped = value; } }

    private void OnEnable()
    {
        equipText.SetActive(equipped);
    }

    public void OnClickButton()
    {
        //inventory.SelectItem(index);
    }
}