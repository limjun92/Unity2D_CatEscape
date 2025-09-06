using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Image hpGauge;
    public Text gameStatus;

    public void DecreaseHp()
    {
        hpGauge.fillAmount -= 0.1f;
    }

    void Update()
    {
        if(hpGauge.fillAmount <= 0)
        {
            gameStatus.text = "Game Over";
            Time.timeScale = 0;
        }
    }
}
