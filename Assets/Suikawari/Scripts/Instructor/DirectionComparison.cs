using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionComparison : MonoBehaviour
{
    [SerializeField]
    Transform player, waterMelon;
    [SerializeField]
    ExistCheck checkerCube;

    [SerializeField]
    readonly float VaildValue = 8;
    readonly float AngleCriteria = 0;

    float angle;

    public enum Directions
    {
        Left,
        Right,
        Front,
        Back,
        Near
    }

    private void Update()
    {
        // https://tsubakit1.hateblo.jp/entry/2018/02/05/235634
        var diff = waterMelon.position - player.position;

        var axis = Vector3.Cross(player.forward, diff);

        angle = Vector3.Angle(player.forward, diff) * (axis.y < 0 ? -1 : 1);

    }

    public Directions GetDirection()
    {
        var plus = AngleCriteria + VaildValue;
        var minus = AngleCriteria - VaildValue;

        if (angle > 90 || angle < -90)
        {
            return Directions.Back;
        }

        if (angle > plus)
        {
            return Directions.Right;
        }
        else if (angle < minus)
        {
            return Directions.Left;
        }

        if (checkerCube.IsExist)
        {
            return Directions.Near;
        }
        return Directions.Front;
    }
}
