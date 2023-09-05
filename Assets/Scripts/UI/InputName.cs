using TMPro;
using UnityEngine;

public class InputName : UI
{
    [SerializeField] private TextMeshProUGUI InputField;
    [SerializeField] private GameObject SelectParent;
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
        SetActive(false);
    }

    public void SelectCharacterBtn()
    {
        UIManager.Instance._uiList[(int)(UIType.SelectCharacter)].SetActive(true);
    }

}
