using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    [SerializeField] ItemData item;

    [SerializeField] Button button;
    [SerializeField] Image icon;
    [SerializeField] TextMeshProUGUI quantityText;
    [SerializeField] GameObject equipText;

    [SerializeField] UIInventory inventory;

    private int index;
    public int Index { get {  return index; } }
    private int quantity;
    public int Quantity { get { return quantity; } }
    private bool equipped;
    public bool Equipped { get { return equipped; } }

    private void OnEnable()
    {
        equipText.SetActive(equipped);
    }

    public void Set()
    {
        icon.gameObject.SetActive(true);
        icon.sprite = item.itemIcon;
        quantityText.text = quantity > 1 ? quantity.ToString() : string.Empty;

        if (equipText != null)
        {
            equipText.SetActive(equipped);
        }
    }

    public void Clear()
    {
        item = null;
        icon.gameObject.SetActive(false);
        quantityText.text = string.Empty;
    }

    public void OnClickButton()
    {
        //inventory.SelectItem(index);
    }
}
