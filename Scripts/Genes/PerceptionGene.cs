using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerceptionGene : MonoBehaviour
{
    [SerializeField] private Light _light;
    [SerializeField] private float _multyplier = 1.05f;
    private float _perception;
    private int _perceptionLevel = 1;

    private void Awake() {
        _perception = _light.spotAngle;
    }

    public void IncreasePerception()
    {
        if(_perceptionLevel < 8)
        {
            _perception *= _multyplier;
            _perceptionLevel++;
            _light.spotAngle = _perception;
        }
    }
}