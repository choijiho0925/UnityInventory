using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject character;

    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    private Character player;
    public Character Player { get { return player; } }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            SetData();
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void SetData()
    {
        player = character.GetComponent<Character>();

        Player.SetData("���̸�", "����ȣ", "���Ĵٵ�", "���ΰ��̸Ӹ� �ϴٰ� ���� �� �ڵ� �Թ��� �ڸ���");

        UIManager.Instance.Character = player;
        UIManager.Instance.MainMenu.SetInfo(player);
        UIManager.Instance.Status.SetInfo(player);
    }
}