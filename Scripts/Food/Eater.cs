using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Eater : MonoBehaviour
{
        private int _Mfullness = 0;

    public void EatFood(int _fullness)
    {
        if(_fullness >= 0)
        {
            _Mfullness += _fullness;
        } else throw new Exception("Incorrect fullness");
    }
}
