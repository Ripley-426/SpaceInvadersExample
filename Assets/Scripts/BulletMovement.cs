using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] public float bulletSpeed = 5f;

    private void Update()
    {
        Transform goTransform = transform;
        goTransform.position += goTransform.up * bulletSpeed * Time.deltaTime;

        if (transform.position.y > 6)
        {
            Destroy(gameObject);
        }
    }
}
