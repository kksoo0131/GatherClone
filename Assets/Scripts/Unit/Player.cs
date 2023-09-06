using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{
    [SerializeField] private Collider2D _range;

    // ������ Ʈ���� �ݶ��̴��� Npc���� ����ִ´�.

    // �÷��̾ �� ���� �ȿ� ����

    // �÷��̾� Ŭ�������� UI�� ȣ���Ѵ�.

    // �̶� collision.gameObject�� ������ �޾Ƽ� UI�� �����ؼ� ȣ����

    // UI�̸��� NpcInfo�� ����


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
