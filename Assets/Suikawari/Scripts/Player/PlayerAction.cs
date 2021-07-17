using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAction : MonoBehaviour
{
    readonly string swingParam = "isSwing";
    [SerializeField]
    Animator stick;

    [SerializeField]
    PowerGageHandler gage;

    public void OnFire(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            gage.StartGage();
        } else if (context.canceled)
        {
            gage.StopGage();
            stick.SetBool(swingParam, true);
        }
    }
}
