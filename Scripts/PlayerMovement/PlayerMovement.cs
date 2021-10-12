using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float _speed;

    [SerializeField] private float _airMultyplier = 0.4f;
    private Animator _animator;
    private MovementControls _controls;
    private float _movementMultyplier = 10f;
    private Vector3 _force;

    private void Awake() 
    {
        _controls = GetComponent<MovementControls>();
        _animator = GetComponent<Animator>();
    }

    private void Update() 
    {
        _controls.LookControl();
        _controls._input.KeyboardInput();
        if(_controls._input._hLook != 0 || _controls._input._vLook != 0)
        {
            _animator.SetBool("Moving", true);
        }else if(_controls._input._hLook == 0 && _controls._input._vLook == 0)
        {
            _animator.SetBool("Moving", false);
        }
    }

    private void FixedUpdate() 
    {
        if(!_controls._isGrounded)
        {
            MovePlayer();
        }
    }

    private void MovePlayer()
    {
        _force = _controls._input._moveDirection.normalized * _speed * _movementMultyplier;
        if(!_controls._isGrounded)
        {
            _force *= _airMultyplier;
        }
        _controls._rigidbody.AddForce(_force, ForceMode.Acceleration);
    }
}