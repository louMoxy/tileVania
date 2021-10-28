using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float enemySpeed = 1f;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(enemySpeed, 0);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        enemySpeed = -enemySpeed;
        FlipSprite();
    }

    private void FlipSprite()
    {
        transform.localScale = new Vector2((-Mathf.Sign(rb.velocity.x)), 1);
    }
}
