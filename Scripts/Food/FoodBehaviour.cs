using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBehaviour : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    public Food _food;
    [SerializeField] private int _fullness;
    [SerializeField] private int _experience;

    private void Awake() {
        _fullness = _food._fullness;
        _experience = _food._experience;
    }

    private void Update() {
        transform.Rotate(new Vector3(0, _rotationSpeed, 0) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.GetComponent<Eater>() != null)
        {
            other.gameObject.GetComponent<Eater>().EatFood(_fullness);
            Destroy(this.gameObject);
        }
    }
}
