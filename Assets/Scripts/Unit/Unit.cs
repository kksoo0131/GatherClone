using UnityEngine;
using TMPro;

public class Unit : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameTxt;

    private void Update()
    {
        SettingName();
    }
    public void SettingName()
    {
        if (name != nameTxt.text)
        {
            nameTxt.text = name.ToString();
        }
    }

}
