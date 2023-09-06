using UnityEngine;
using System.Collections.Generic;
using System.Text;
public class UnitManager : MonoBehaviour
{
    public static UnitManager Instance {  get; private set; }

    // 맵에 있는 플레이어, Npc 들의 목록을 모두 관리해야됨
    public List<GameObject> _unitList { get; private set; }
    public GameObject Player { get; set; }
    public GameObject PlayerCharacter { get; set; }

    StringBuilder sb = new StringBuilder();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        _unitList = new List<GameObject>();
    }

    private void Start()
    {
        CreateMyPlayer();

        Unit[] playerArray = FindObjectsOfType<Unit>();

        foreach(Unit p in playerArray)
        {
            _unitList.Add(p.gameObject);
        }
    }

    public string ListToString()
    {
        foreach(GameObject go in _unitList)
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
        Player = go;
        PlayerCharacter = go.transform.GetChild(0).gameObject; 
    }

    public void ChangePlayerName(string name)
    {
        Player.name = name;
    }

    public void ChangePlayerSprite(CharacterType type)
    {
        Destroy(PlayerCharacter.gameObject);
        GameObject go = (GameObject)Instantiate(Resources.Load($"Prefabs/{type}"));
        go.transform.SetParent(Player.transform);
        PlayerCharacter = go;
        go.transform.localPosition = Vector3.zero;

    }
}

