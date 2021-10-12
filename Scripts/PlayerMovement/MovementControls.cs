using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControls : MonoBehaviour
{
    [Header("Objects")]
    public Transform _gfx;
    [Header("Jumping")]
    [SerializeField] private float _playerHeight = 0.5f;

    [HideInInspector] public Rigidbody _rigidbody;
    [HideInInspector] public PlayerInput _input;
    [HideInInspector] public bool _isGrounded;
    

    private void Awake() {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.freezeRotation = true;
        _input = GetComponent<PlayerInput>();
    }

    private void Update() {
        _isGrounded = Physics.Raycast(_gfx.transform.position, Vector3.down, _playerHeight/2 + 0.1f);
    }

    public void LookControl()
    {
        _gfx.transform.LookAt(_gfx.transform.position + _input._lookDirection.normalized, _gfx.transform.up);
    }

    public void SetDrag(float _drag)
    {
        _rigidbody.drag = _drag;
    }
}