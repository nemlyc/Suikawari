using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuikawariTimer : MonoBehaviour
{
    /*
     * This is count down timer.
     */
    int minutes;
    float seconds;
    float mseconds;
    float timer;

    string currentTime;
    bool isStop = true;

    readonly float LimitedTime = 60;

    private void Awake()
    {
        timer = LimitedTime;
    }

    private void Update()
    {
        if (isStop)
        {
            return;
        }
        //内部での経過時間
        timer -= Time.deltaTime;

        minutes = Mathf.FloorToInt(timer / 60f);
        seconds = Mathf.FloorToInt(timer - minutes * 60);
        mseconds = Mathf.FloorToInt((timer - minutes * 60 - seconds) * 100);
        
        Debug.Log(GetCurrentTime());
    }

    /// <summary>
    /// 経過時間をリセットして、タイマーをスタートする。
    /// </summary>
    public void StartTimer()
    {
        if (!isStop)
        {
            return;
        }
        isStop = false;
        timer = 0;
        Debug.Log("Timer started.");
    }

    /// <summary>
    /// タイマーをストップする。
    /// </summary>
    public void StopTimer()
    {
        isStop = true;
        currentTime = GetCurrentTime();// これ意味ある？
        Debug.Log("Timer stopped. Time : " + currentTime);
    }

    /// <summary>
    /// 現在のタイマーの経過時間を取得する。
    /// </summary>
    /// <returns>タイマーの経過時間</returns>
    public string GetCurrentTime()
    {
        currentTime = $"{GetMinutes()}:{GetSeconds()}.{GetMiliseconds()}";
        
        return currentTime;
    }

    public string GetMiliseconds()
    {
        return SetFormat(mseconds);
    }

    public string GetSeconds()
    {
        return SetFormat(seconds);
    }

    public string GetMinutes()
    {
        return SetFormat(minutes);
    }

    string SetFormat(float time)
    {
        return string.Format("{0:00}", time);
    }
}
