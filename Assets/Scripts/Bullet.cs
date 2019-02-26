using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject deadthEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerStats player = collision.GetComponent<playerStats>();
        if (player != null)
        {
            player.PlaySound();
            player.TakeDamage(1);
        }
        Destroy(gameObject);
        Instantiate(deadthEffect, transform.position, Quaternion.identity);
    }
}
