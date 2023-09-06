using System.Collections;
using TMPro;
using UnityEngine;

public class NpcInfo : UI
{
    [SerializeField] private TextMeshProUGUI text;

    private GameObject target;
    public  void OnNpcInfo(GameObject go)
    {
        base.OnUI();
        target = go;
        text.text = target.name;
    }

    public void TalkBtn()
    {
        OffUI();
        Talk ui = (Talk)UIManager.Instance._uiList[(int)UIType.Talk];
        ui.OnTalk(target.GetComponent<Npc>());

    }
}
