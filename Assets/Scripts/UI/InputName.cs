using TMPro;
using UnityEngine;
using System.Collections.Generic;

public class InputName : UI
{
    [SerializeField] private TextMeshProUGUI InputField;
    [SerializeField] private GameObject Select;
    public List<GameObject> _selectCharList { get; private set; }
    int selectIndex = 0;

    private void Start()
    {
        _selectCharList = new List<GameObject>();

        int n = Select.transform.childCount;

        for(int i=0; i< n; i++)
        {
            _selectCharList.Add(Select.transform.GetChild(i).gameObject);
        }

    }

    public void JoinBtn()
    {
        string text = InputField.text;
        if (text.Length < 2 || text.Length > 10)
        {
            Debug.Log("2~10 글자 사이로 이름을 입력해주세요");
            return;
        }
        UnitManager.Instance.ChangePlayerName(text);
        GameManager.Instance.GameStart();
        OffUI();
    }

    public void ChangeCharacterBtn()
    {
        UIManager.Instance._uiList[(int)UIType.ChangeCharacter].OnUI();
    }

    public void ChangeSelected(int index)
    {
        _selectCharList[selectIndex].SetActive(false);
        selectIndex = index;
        _selectCharList[selectIndex].SetActive(true);
        
    }

}
