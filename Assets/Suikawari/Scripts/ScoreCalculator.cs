using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreCalculator : MonoBehaviour
{
    [SerializeField]
    PowerGageHandler GageHandler;

    [SerializeField]
    SuikawariTimer timer;

    readonly float GageMagnification = 100;

    readonly float TimeMagnification = 2; // 最速10秒で見つけられる想定

    float gotPositionScore = 0;

    float resultScore;

    public void SetSeparetedPosition(float score)
    {
        if (gotPositionScore == 0)
        {
            gotPositionScore = score;
        }
    }

    public void InterruptGame()
    {
        timer.StopTimer();

        CalcScoreData();
    }

    public float CalcScoreData()
    {
        if (gotPositionScore > 0)
        {
            var gageScore = FixedGageScore();
            var timeScore = FixedTimeScore();
            resultScore = gageScore * gotPositionScore * timeScore;
            Debug.Log($"{gageScore} x {gotPositionScore} x {timeScore} = {resultScore}");
            return resultScore;
        }

        return -1;
    }

    float FixedGageScore()
    {
        return GageMagnification * GageHandler.GetGageValue();
    }

    float FixedTimeScore()
    {
        var rawTime = timer.GetSeconds();
        var time = int.Parse(rawTime);
        Debug.Log($"time : {time}, fixedTime : {time * TimeMagnification}");
        return time * TimeMagnification;
    }
}