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

        Player.SetData("게이머", "최지호", "스탠다드", "프로게이머를 하다가 전역 후 코딩 입문한 코린이");

        UIManager.Instance.Character = player;
        UIManager.Instance.MainMenu.SetInfo(player);
        UIManager.Instance.Status.SetInfo(player);
    }
}