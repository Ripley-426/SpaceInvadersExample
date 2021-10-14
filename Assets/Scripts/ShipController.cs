using System;
using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Rigidbody2D))]
public class ShipController : MonoBehaviour
{
    [SerializeField] private new Rigidbody2D rigidbody;
    [SerializeField] private float speed = 1f;
    
    private Vector2 _position;
    private Translator _trans;

    private void Awake()
    {
        _trans = gameObject.AddComponent<Translator>();
        _position = transform.position;
        SetRandomXPosition();
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        _trans.Move(new Vector2(moveHorizontal, moveVertical) * speed);
    }

    private void SetRandomXPosition()
    {
        float posX = Random.Range(-7f, 7f);
        transform.position = new Vector3(posX, _position.y, 0);
    }
}