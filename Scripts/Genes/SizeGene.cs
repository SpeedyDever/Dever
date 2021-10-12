using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeGene : MonoBehaviour
{
    [SerializeField] private float _multyplier = 1.1f;
    [SerializeField] private Transform _gfx;
    public float _size;
    public int _sizeLevel = 1;

    private void Awake() {
        _size = _gfx.localScale.x;
    }

    public void IncreaseSize()
    {
        _size *= _multyplier;
        _sizeLevel++;
        _gfx.localScale = new Vector3(_size, _size, _size);
    }
}
