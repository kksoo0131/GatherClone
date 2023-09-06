using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : UI
{
    public void PlayerListBtn()
    {
        UIManager.Instance._uiList[(int)UIType.PlayerList].OnUI();
    }

    public void ChangeCharacterBtn()
    {
        UIManager.Instance._uiList[(int)UIType.ChangeCharacter].OnUI();
    }

    public void ChangeNameBtn()
    {
        UIManager.Instance._uiList[(int)UIType.ChangeName].OnUI();
    }
}
