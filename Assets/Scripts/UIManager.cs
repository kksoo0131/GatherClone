using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UIType
{
    InputName,
    SelectCharacter,
    EndPoint,

}

public class UIManager : MonoBehaviour
{
    // 싱글톤 클래스인 UIManager를 통해서
    // 모든 UI클래스에 접근할 수 있다.
    public static UIManager Instance { get; private set; }

    public List<UI> _uiList { get; private set; }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }

        _uiList = new List<UI>();

        for (int i=0; i < (int)UIType.EndPoint; i++)
        {
            
            GameObject go = Instantiate(Resources.Load<GameObject>($"Prefabs/{((UIType)i)}"));
            _uiList.Add(go.GetComponent<UI>());
        }
    }

    private void Start()
    {
        
    }

    public void OnUI(UIType type)
    {
        _uiList[(int)type].SetActive(true);
    }


    public void OffUI(UIType type)
    {
        _uiList[(int)type].SetActive(false);
    }
}
