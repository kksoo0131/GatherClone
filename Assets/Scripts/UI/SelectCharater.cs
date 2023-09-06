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
        // Select ��ư�� ������ �Ǹ� �� UI�� false�ǰ�
        // UI�� ã�ư��� selected�� ĳ���͸� true�� ���־�ߵ�
        // �ش� �Լ��� InputName���� ������ִ°� ������?
        InputName inputNameUI = (InputName)(UIManager.Instance._uiList[(int)UIType.InputName]);
        inputNameUI.ChangeSelected(index);
        OffUI();
    }
}
