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
    // �̱��� Ŭ������ UIManager�� ���ؼ�
    // ��� UIŬ������ ������ �� �ִ�.
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
