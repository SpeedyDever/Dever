using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Food", menuName = "Food")]
public class Food : ScriptableObject
{
    public int _fullness;
    public int _experience;
    public int _probability;
    public GameObject _prefab;
}
