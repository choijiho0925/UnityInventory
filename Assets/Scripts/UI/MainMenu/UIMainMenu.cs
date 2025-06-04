using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] TextMeshProUGUI nickNameNext;
    [SerializeField] TextMeshProUGUI iDText;
    [SerializeField] TextMeshProUGUI descriptionText;
    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] TextMeshProUGUI goldText;
    [SerializeField] Image profileImage;
    [SerializeField] Button statusButton;
    [SerializeField] Button inventoryButton;
    [SerializeField] Button goBackButton;

    private void Awake()
    {
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
        goBackButton.onClick.AddListener(OpenMainMenu);
    }

    private void OpenStatus()
    {
        UIManager.Instance.Status.Open();
        CloseButton();
    }

    private void OpenInventory()
    {
        UIManager.Instance.Inventory.Open();
        CloseButton();
    }

    private void OpenMainMenu()
    {
        UIManager.Instance.Inventory.Close();
        UIManager.Instance.Status.Close();
        OpenButton();
    }

    private void OpenButton()
    {
        statusButton.gameObject.SetActive(true);
        inventoryButton.gameObject.SetActive(true);
        goBackButton.gameObject.SetActive(false);
    }

    private void CloseButton()
    {
        statusButton.gameObject.SetActive(false);
        inventoryButton.gameObject.SetActive(false);
        goBackButton.gameObject.SetActive(true);
    }

    public void SetInfo(Character character)
    {
        nickNameNext.text = $"{character.NickName}";
        iDText.text = $"{character.ID}";
        levelText.text = $"{character.Level}";
        descriptionText.text = $"{character.Description}";
    }
}