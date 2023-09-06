using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{
    [SerializeField] private Collider2D _range;

    // 투명한 트리거 콜라이더를 Npc들이 들고있는다.

    // 플레이어가 그 영역 안에 들어가면

    // 플레이어 클래스에서 UI를 호출한다.

    // 이때 collision.gameObject의 정보를 받아서 UI를 갱신해서 호출함

    // UI이름은 NpcInfo로 하자


    private void OnTriggerEnter2D(Collider2D collision)
    {
        NpcInfo npcInfoui = (NpcInfo)UIManager.Instance._uiList[(int)(UIType.NpcInfo)];

        npcInfoui.OnNpcInfo(collision.transform.parent.gameObject);
        
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        UIManager.Instance._uiList[(int)(UIType.NpcInfo)].OffUI();
    }
}
