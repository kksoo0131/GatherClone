using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputName : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI InputField;
    [SerializeField] private GameObject SelectParent;
    [SerializeField] private GameObject SelectCharacter;
    private int selectIndex =0;

    public void JoinBtn()
    {
        string text = InputField.text;
        if (text.Length < 2 || text.Length > 10)
        {
            Debug.Log("2~10 글자 사이로 이름을 입력해주세요");
            return;
        }
        GameManager.Instance.CreatePlayer(InputField.text.ToString(), (CharacterType)selectIndex);
        UIManager.Instance.OffUI(gameObject);
    }

    public void SelectCharacterBtn()
    {
        SelectCharacter.SetActive(true);
    }

    public void SelectBtn(int index)
    {
        SelectCharacter.SetActive(false);
        SelectParent.transform.GetChild(selectIndex).gameObject.SetActive(false);
        selectIndex = index;
        SelectParent.transform.GetChild(selectIndex).gameObject.SetActive(true);
    }
}
