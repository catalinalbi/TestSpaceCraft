using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour
{
    public int health = 100;
    public GameObject deadthEffect;
    public AudioSource openSound;
    public HPBarManagement player;

    public void TakeDamage(int damage)
    {
        health -= damage;
        player.UpdateHealthbar();
        if (health <= 0)
            Die();
    }

    void Die()
    {
        Instantiate(deadthEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlaySound()
    {
        openSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
