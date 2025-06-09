using UnityEngine;

public class GameManager : MonoBehaviour
{
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
        GameObject playerObj = new GameObject("Player");
        player = playerObj.AddComponent<Character>();
        player.gameObject.AddComponent<Condition>();

        Player.SetData("게이머", "최지호", "스탠다드", "프로게이머를 하다가 전역 후 코딩 입문한 코린이");

        UIManager.Instance.Character = player;
        UIManager.Instance.MainMenu.SetInfo(player);
        UIManager.Instance.Status.SetInfo(player);
    }
}