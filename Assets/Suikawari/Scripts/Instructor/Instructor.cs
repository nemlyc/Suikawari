using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructor : MonoBehaviour
{
    [SerializeField]
    GameObject rightDialogue, leftDialogue, centerDialogue, nearDialogue, frontDialogue;

    [SerializeField]
    DirectionComparison compare;

    private void Update()
    {
        var dir = compare.GetDirection();
        switch (dir)
        {
            case DirectionComparison.Directions.Left:
                SetActive(leftDialogue);
                break;
            case DirectionComparison.Directions.Right:
                SetActive(rightDialogue);
                break;
            case DirectionComparison.Directions.Back:
                SetActive(centerDialogue);
                break;
            case DirectionComparison.Directions.Near:
                SetActive(nearDialogue);
                break;
            case DirectionComparison.Directions.Front:
                SetActive(frontDialogue);
                break;
            default:
                SetActive();
                break;
        }
    }

    void SetActive(GameObject activeObject)
    {
        SetActive();

        activeObject.SetActive(true);
    }
    void SetActive()
    {
        rightDialogue.SetActive(false);
        leftDialogue.SetActive(false);
        centerDialogue.SetActive(false);
        nearDialogue.SetActive(false);
        frontDialogue.SetActive(false);
    }


}
