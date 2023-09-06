using UnityEngine;
using System.Collections.Generic;
using System.Text;
public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance {  get; private set; }

    // 맵에 있는 플레이어, Npc 들의 목록을 모두 관리해야됨
    public List<GameObject> _playerList { get; private set; }
    public GameObject MyPlayer { get; set; }
    public GameObject MyPlayerCharacter { get; set; }

    StringBuilder sb = new StringBuilder();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        _playerList = new List<GameObject>();
    }

    private void Start()
    {
        CreateMyPlayer();

        Player[] playerArray = FindObjectsOfType<Player>();

        foreach(Player p in playerArray)
        {
            _playerList.Add(p.gameObject);
        }
    }

    public string ListToString()
    {
        foreach(GameObject go in _playerList)
        {
            sb.Append("   ");
            sb.Append($"{go.name}");
            sb.Append("\n");
        }

        string returnTemp = sb.ToString();
        sb.Clear();
        return returnTemp;
    }
    public void CreateMyPlayer()
    {
        GameObject go = (GameObject)Instantiate(Resources.Load($"Prefabs/Player"));        
        MyPlayer = go;
        MyPlayerCharacter = go.transform.GetChild(0).gameObject; 
    }

    public void ChangePlayerName(string name)
    {
        MyPlayer.name = name;
    }

    public void ChangePlayerSprite(CharacterType type)
    {
        Destroy(MyPlayerCharacter.gameObject);
        GameObject go = (GameObject)Instantiate(Resources.Load($"Prefabs/{type}"));
        go.transform.SetParent(MyPlayer.transform);
        MyPlayerCharacter = go;
        go.transform.localPosition = Vector3.zero;

    }
}

