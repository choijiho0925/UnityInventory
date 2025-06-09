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

    public void SetInfo(Character character)
    {
        Condition condition = character.GetComponent<Condition>();
        if (condition == null) return;

        healthText.text = $"{condition.Health}hp";
        reactionSpeedText.text = $"{condition.ReactionSpeed}ms";
        iqText.text = $"{condition.IQLevel}IQ";
        codingPowerText.text = $"{condition.CodingPower}CP";
    }
}