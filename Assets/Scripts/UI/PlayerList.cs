using TMPro;
using UnityEngine;

public class PlayerList : UI
{
    [SerializeField] private TextMeshProUGUI playerListTxt;

    float coolDown = 0f;
    private void Update()
    {
        coolDown -= Time.deltaTime;

        if(coolDown < 0)
        {
            UpdatePlayerListTxt();
        }
    }

    public override void OnUI()
    {
        base.OnUI();
        UpdatePlayerListTxt();
    }
    public void Esc()
    {
        OffUI();
    }

    public void UpdatePlayerListTxt()
    {
        playerListTxt.text = PlayerManager.Instance.ListToString();
        coolDown = 1f;
    }
}
