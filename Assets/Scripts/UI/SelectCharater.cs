using System.Collections.Generic;
using UnityEngine;

public class SelectCharater : UI
{
    // �Ʒ���ư���� Active�� ������ �� �־����
    // �ϳ��� ������
    // �ٸ��� �����ߵ�
    // ������ �������ִٰ� -> ���� -> �����ɷ� ����
    // GetChild�� �ݺ��ϴ°ͺ��ٴ� List�� �������ִ°� ������?

    public List<GameObject> selectList;
    private void Awake()
    {
        selectList = new List<GameObject>();

        for(int i =0;)
    }
    public void SelectBtn(int index)
    {
        SetActive(false);
        SelectParent.transform.GetChild(selectIndex).gameObject.SetActive(false);
        selectIndex = index;
        SelectParent.transform.GetChild(selectIndex).gameObject.SetActive(true);
    }
}
