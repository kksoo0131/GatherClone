using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : UI
{
    public void PlayerListBtn()
    {
        UIManager.Instance._uiList[(int)UIType.PlayerList].OnUI();
    }

    public void SelectCharacterBtn()
    {
        UIManager.Instance._uiList[(int)UIType.SelectCharacter].OnUI();
    }
}
