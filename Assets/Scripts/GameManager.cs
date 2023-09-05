using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public GameObject Player { get; set; }
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
        UIManager.Instance.OnUI(UIType.InputName);
    }

    public void CreatePlayer(string name)
    {
        Player = (GameObject)Instantiate(Resources.Load("Prefabs/Player"));
        Player.name = name;
    }
}