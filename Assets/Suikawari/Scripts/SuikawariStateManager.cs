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


    public enum State{
        Start,
        Playing,
        Result
    }

    public State CurrentState { get; private set; }

    private void Awake()
    {
        SetState(State.Playing);//Debug
        ToPlaying();
    }

    private void Update()
    {
        /*
         * ステートの切り替えとか。
         */
        if (waterMelon.IsBroken)
        {
            CurrentState = State.Result;
            ToResult();
        }

        /*
         * ステートの状態に応じた操作系の切り替え。
         * ここから参照することで、他でハード参照を控える。
         */



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

    private void ToPlaying()
    {
        movement.IsPlaying = true;
        action.IsPlaying = true;
        
    }

    private void ToResult()
    {
        movement.IsPlaying = false;
        action.IsPlaying = false;
        //カメラの切り替え
    }
}
