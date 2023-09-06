using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public Camera Camera { get; set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        Camera = Camera.main;
        UIManager.Instance._uiList[(int)UIType.InputName].OnUI();
    }

    public void GameStart()
    {
        UIManager.Instance._uiList[(int)UIType.MainUI].OnUI();
    }
    
}