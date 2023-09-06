using UnityEngine;
using TMPro;

public class ChangeName : UI
{
    [SerializeField] private TextMeshProUGUI InputField;
    
    public void ChangeNameBtn()
    {
        string text = InputField.text;
        if (text.Length < 2 || text.Length > 10)
        {
            Debug.Log("2~10 글자 사이로 이름을 입력해주세요");
            return;
        }
        PlayerManager.Instance.ChangePlayerName(text);
        OffUI();
    }
}
