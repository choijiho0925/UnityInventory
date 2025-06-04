using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private UIMainMenu mainMenu;
    public UIMainMenu MainMenu { get { return mainMenu; } }
    [SerializeField] private UIInventory inventory;
    public UIInventory Inventory { get { return inventory; } }
    [SerializeField] private UIStatus status;
    public UIStatus Status { get { return status; } }

    private static UIManager instance;
    public static UIManager Instance { get { return instance; } }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
}