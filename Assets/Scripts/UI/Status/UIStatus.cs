using TMPro;
using UnityEngine;

public class UIStatus : MonoBehaviour
{
    [SerializeField] GameObject uiStatus;
    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] TextMeshProUGUI reactionSpeedText;
    [SerializeField] TextMeshProUGUI iqText;
    [SerializeField] TextMeshProUGUI codingPowerText;

    public void Open()
    {
        uiStatus.SetActive(true);
    }

    public void Close()
    {
        uiStatus.SetActive(false);
    }
}