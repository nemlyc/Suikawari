using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuikawariStateManager : MonoBehaviour
{
    [SerializeField]
    WaterMelonAction waterMelon;
    [SerializeField]
    PlayerMovement movement;
    [SerializeField]
    PlayerAction action;
    [SerializeField]
    SuikawariTimer timer;
    [SerializeField]
    UISwitcher switcher;


    public enum State{
        Start,
        Playing,
        Result
    }

    public State CurrentState { get; private set; }

    private void Awake()
    {
        //ToPlaying();
    }

    private void Update()
    {
        if (waterMelon.IsBroken)
        {
            SetState(State.Result);
            ToResult();
        }

        if (timer.IsEnd())
        {
            ToResult();
        }

    }

    public bool IsPlaying()
    {
        if (CurrentState.Equals(State.Playing))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SetState(State state)
    {
        CurrentState = state;
    }

    public void ToPlaying()
    {
        movement.IsPlaying = true;
        action.IsPlaying = true;

        SetState(State.Playing);
    }

    public void ToResult()
    {
        movement.IsPlaying = false;
        action.IsPlaying = false;

        SetState(State.Result);

        switcher.ShowResult();

        //カメラの切り替え

    }
}
