using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomRotation : MonoBehaviour
{
    public int rotationDirection;
    [SerializeField] public float rotationSpeed = 5f;
    private GameObject _go;

    private void Awake()
    {
        _go = gameObject;
        rotationDirection = SetRotationDirection();
    }

    private int SetRotationDirection()
    {
        if (5 < Random.Range(0, 10))
        {
            return -1;
        }

        return 1;
    }

    private void Update()
    {
        ApplyRotation();
    }

    private void ApplyRotation()
    {
        transform.Rotate(0,0, rotationDirection * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
