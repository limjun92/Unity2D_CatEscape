using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Image hpGauge;

    public void DecreaseHp()
    {
        hpGauge.fillAmount -= 0.1f;
    }
}
