using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;
    public static UIManager Instance { get { return instance; } }

    [SerializeField] UIMainMenu mainMenu;
    public UIMainMenu MainMenu { get { return mainMenu; } }

    [SerializeField] UIInventory inventory;
    public UIInventory Inventory { get { return inventory; } }

    [SerializeField] UIStatus status;
    public UIStatus Status { get { return status; } }

    [SerializeField] Character character;
    public Character Character { get { return character; } set { character = value; } }

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