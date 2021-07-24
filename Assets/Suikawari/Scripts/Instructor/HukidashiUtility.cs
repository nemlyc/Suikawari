using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HukidashiUtility : MonoBehaviour
{
    [SerializeField]
    TMPro.TMP_Text text;

    [SerializeField]
    string textContent;

    public void SetText()
    {
        text.text = textContent;
    }
}
