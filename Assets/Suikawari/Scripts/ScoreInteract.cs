using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreInteract : MonoBehaviour, IInteractable
{
    [SerializeField]
    float Score;

    [SerializeField]
    ScoreCalculator calculator;

    public void Interact()
    {
        calculator.SetSeparetedPosition(Score);
        calculator.InterruptGame();
    }
}
