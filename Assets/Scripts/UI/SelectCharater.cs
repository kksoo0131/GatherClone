using System.Collections.Generic;
using UnityEngine;

public class SelectCharater : UI
{
    // 아래버튼들의 Active를 관리할 수 있어야함
    // 하나가 켜지면
    // 다른건 꺼져야됨
    // 켜진걸 가지고있다가 -> 끄고 -> 다음걸로 변경
    // GetChild를 반복하는것보다는 List로 가지고있는게 나을까?

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
