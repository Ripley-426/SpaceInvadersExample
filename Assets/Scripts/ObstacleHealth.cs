using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHealth : MonoBehaviour
{
    [SerializeField] private Sprite fullHealth;
    [SerializeField] private Sprite damagedHealth;
    [SerializeField] private Sprite almostDead;
    [SerializeField] private SpriteRenderer spriteRenderer;

    [SerializeField] private int health = 3;

    private void Update()
    {
        switch (health)
        {
            case 3:
                spriteRenderer.sprite = fullHealth;
                break;
            case 2:
                spriteRenderer.sprite = damagedHealth;
                break;
            default:
                spriteRenderer.sprite = almostDead;
                break;
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        ReduceHealth(1);
    }

    private void ReduceHealth(int damage)
    {
        health -= damage;
    }
}
