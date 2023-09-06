using System.Collections.Generic;
using UnityEngine;

public class SelectCharater : UI
{
    public List<GameObject> selectList;
    private void Awake()
    {
        selectList = new List<GameObject>();
    }
    public void SelectBtn(int index)
    {
        // Select 버튼을 누르게 되면 이 UI는 false되고
        // UI를 찾아가서 selected된 캐릭터를 true로 해주어야됨
        // 해당 함수는 InputName측에 만들어주는게 맞을듯?
        InputName inputNameUI = (InputName)(UIManager.Instance._uiList[(int)UIType.InputName]);
        inputNameUI.ChangeSelected(index);
        OffUI();
    }
}
