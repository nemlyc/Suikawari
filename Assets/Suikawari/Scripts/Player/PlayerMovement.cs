using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    PlayerData playerData;

    Vector3 move;

    public bool IsPlaying { private get; set; }


    public void OnMove(InputAction.CallbackContext context)
    {
        var v = context.ReadValue<Vector2>();
        move = new Vector3(v.x, 0, v.y);
    }

    private void Update()
    {
        if (IsPlaying)
        {
            Movement();
        }
    }

    public void Movement()
    {
        transform.rotation = Camera.main.transform.rotation;
        transform.Translate(move * playerData.MoveSpeed * Time.deltaTime);
    }
}
