using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : UI
{
    public void PlayerListBtn()
    {
        UIManager.Instance._uiList[(int)UIType.PlayerList].OnUI();
    }
}
