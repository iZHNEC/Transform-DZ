using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRedCube : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _growthSpeed;

    void Update()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
        transform.localScale += Vector3.one * _growthSpeed * Time.deltaTime;
    }
}
