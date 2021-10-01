using System;
using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Rigidbody2D))]
public class ShipController : MonoBehaviour
{
    [SerializeField] private new Rigidbody2D rigidbody;
    [SerializeField] private float speed = 1f;
    [SerializeField] private float movementMultiplier = 5f;
    
    private Vector2 _movement;
    private Vector2 _position;

    public Vector2 realSpeed;

    private void Awake()
    {
        _position = transform.position;
        SetRandomXPosition();
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        _movement = new Vector2(moveHorizontal, 0f);
    }

    private void FixedUpdate()
    {
        realSpeed = _movement * speed * movementMultiplier;
        rigidbody.AddForce(_movement * speed * movementMultiplier);
    }

    private void SetRandomXPosition()
    {
        float posX = Random.Range(-7f, 7f);
        transform.position = new Vector3(posX, _position.y, 0);
    }
}