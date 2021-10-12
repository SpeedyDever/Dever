using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    [SerializeField] private List<Transform> FreeSpawnPoints = new List<Transform>();
    [SerializeField] private List<Food> FoodTypes = new List<Food>();
    [SerializeField] private int _foodCount = 25;

    public void Spawn()
    {
        if(FreeSpawnPoints.Count != 0)
        {
            GameObject _food = CalculateFoodObject();
            Vector3 _spawnPoint = ChooseSpawnPoint();
            Instantiate(_food, _spawnPoint, Quaternion.identity);
        }
    }

    public Vector3 ChooseSpawnPoint()
    {
        int _pointIndex = Random.Range(0, FreeSpawnPoints.Count - 1);
        Vector3 _spawnPoint = FreeSpawnPoints[_pointIndex].position;
        FreeSpawnPoints.Remove(FreeSpawnPoints[_pointIndex]);
        return _spawnPoint;
    }

    public GameObject CalculateFoodObject()
    {
        int _foodIndex = Random.Range(1, 100);
            if(_foodIndex < FoodTypes[0]._probability + 1)
            {
                return FoodTypes[0]._prefab;
            }else if(_foodIndex < 100 - FoodTypes[2]._probability + 1)
            {
                return FoodTypes[1]._prefab;
            }else if(_foodIndex < 101)
            {
                return FoodTypes[2]._prefab;
            }
            else return FoodTypes[2]._prefab;
    }

    private void Awake() {
        for (int i = 0; i < _foodCount; i++)
        {
            Spawn();
        }
    }
}
