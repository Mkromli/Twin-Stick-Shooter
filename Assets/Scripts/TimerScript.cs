using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Timer;
    [SerializeField] private TextMeshProUGUI KillCount;
    private int timer;
    public int kills;
    private int timerTimer;

    // Update is called once per frame
    void Update()
    {
        timerTimer += 1;

        if (timerTimer >= 600)
        {
            timer += 1;
            timerTimer = 0;

        }
        Timer.SetText(timer.ToString());

        KillCount.SetText(kills.ToString());
    }
}
