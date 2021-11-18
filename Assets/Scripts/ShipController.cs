using System;
using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Rigidbody2D))]
public class ShipController : MonoBehaviour
{
    [SerializeField] private new Rigidbody2D rigidbody;
    [SerializeField] private float speed = 1f;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip shootingSound;
    
    private Vector2 _position;
    private Translator _trans;

    [SerializeField] private float shootingCooldown = 1f;
    private float _currentTime;

    private void Awake()
    {
        _currentTime = shootingCooldown;
        _trans = gameObject.AddComponent<Translator>();
        _position = transform.position;
        SetRandomXPosition();
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        _trans.Move(new Vector2(moveHorizontal, moveVertical) * speed);
        
        ShootLogic();
    }

    private void ShootLogic()
    {
        if (_currentTime < shootingCooldown)
        {
            _currentTime += Time.deltaTime;
            return;
        }
        if (!Input.GetKey(KeyCode.Space)) return;
        _currentTime = 0;
        audioSource.PlayOneShot(shootingSound);
    }

    private void SetRandomXPosition()
    {
        float posX = Random.Range(-7f, 7f);
        transform.position = new Vector3(posX, _position.y, 0);
    }
}