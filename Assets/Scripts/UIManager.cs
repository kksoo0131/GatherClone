using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UIType
{
    InputName,
    EndPoint,

}

public class UIManager : MonoBehaviour
{
    // UI매니저는 각각의 UI창들을 가지고 있다가 UI가 호출되면 부른다.
    public static UIManager Instance { get; private set; }

    List<GameObject> _uiList;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }

        _uiList = new List<GameObject>();

        for (int i=0; i < (int)UIType.EndPoint; i++)
        {
            
            GameObject go = Instantiate(Resources.Load<GameObject>($"Prefabs/{((UIType)i)}"));
            _uiList.Add(go);
        }
    }

    public void OnUI(UIType type)
    {
        _uiList[(int)type].SetActive(true);
    }

    public void OffUI(GameObject go)
    {
        go.SetActive(false);
    }

    public void OffUI(UIType type)
    {
        _uiList[(int)type].SetActive(false);
    }

    public GameObject PeekUI(UIType type)
    {
        return _uiList[(int)type];
    }
}
