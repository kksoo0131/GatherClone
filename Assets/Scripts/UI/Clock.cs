using TMPro;
using UnityEngine;
using System;

public class Clock : UI
{
    [SerializeField] private TextMeshProUGUI text;

    void Start()
    {
        InvokeRepeating("UpdateTime", 0f, 1f);
    }

    private void UpdateTime()
    {
        text.text = System.DateTime.Now.ToString("HH:mm:ss");
    }
}
