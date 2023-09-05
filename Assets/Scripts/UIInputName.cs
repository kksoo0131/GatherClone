using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIInputName : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI InputField;

    public void JoinBtn()
    {
        string text = InputField.text;
        if (text.Length < 2 || text.Length > 10)
        {
            Debug.Log("2~10 ���� ���̷� �̸��� �Է����ּ���");
            return;
        }
        GameManager.Instance.CreatePlayer(InputField.text.ToString());
        UIManager.Instance.OffUI(gameObject);
        
    }
}
