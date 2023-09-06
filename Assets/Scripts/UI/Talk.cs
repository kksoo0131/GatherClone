using TMPro;
using UnityEngine;

public class Talk : UI
{
    [SerializeField] private TextMeshProUGUI text;
    public void OnTalk(Npc npc)
    {
        base.OnUI();
        text.text = npc.talktext;
        UIManager.Instance._uiList[(int)UIType.MainUI].OffUI();
    }

    public void CompletedBtn()
    {
        OffUI();
        UIManager.Instance._uiList[(int)UIType.MainUI].OnUI();
    }

}
