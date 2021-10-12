using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedGene : MonoBehaviour
{
    [SerializeField] private float _multyplier = 1.1f;
    private float _speed;
    private int _speedLevel = 1;
    private PlayerMovement _movement;
    private void Awake() {
        _movement = GetComponent<PlayerMovement>();
        _speed = GetComponent<PlayerMovement>()._speed;
    }

    public void IncreaseSpeed()
    {
        _speed *= _multyplier;
        _speedLevel++;
        _movement._speed = _speed;
    }
}
