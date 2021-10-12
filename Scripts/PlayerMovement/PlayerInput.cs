using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [HideInInspector] public float _hMove;
    [HideInInspector] public float _hLook;
    [HideInInspector] public float _vMove;
    [HideInInspector] public float _vLook;
    [HideInInspector] public Vector3 _moveDirection;
    [HideInInspector] public Vector3 _lookDirection;


    public void KeyboardInput()
    {
        _hMove = Input.GetAxisRaw("Horizontal");
        _vMove = Input.GetAxisRaw("Vertical");
        _moveDirection = transform.forward * _vMove + transform.right * _hMove;

        _hLook = Input.GetAxis("Horizontal");
        _vLook = Input.GetAxis("Vertical");
        _lookDirection = transform.forward * _vLook + transform.right * _hLook;
    }
}