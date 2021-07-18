using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuikawariTimerDisplay : MonoBehaviour
{
    [SerializeField]
    SuikawariTimer timer;
    [SerializeField]
    TMPro.TMP_Text timerText;

    private void Update()
    {
        timerText.text = timer.GetSeconds();
    }
}
