using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] Image icon;
    [SerializeField] GameObject equipText;

    public ItemData data;

    private bool equipped;
    public bool Equipped { get { return equipped; } set { equipped = value; } }

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClickButton);
    }

    public void OnEnable()
    {
        equipText.SetActive(equipped);
    }

    public void OnClickButton()
    {
        GameManager.Instance.Player.Equip(this);
    }

    public void SetData(ItemData itemData)
    {
        data = itemData;
        icon.sprite = data.itemIcon;
        icon.enabled = true;
        equipText.SetActive(equipped);
        gameObject.SetActive(true);
    }
}