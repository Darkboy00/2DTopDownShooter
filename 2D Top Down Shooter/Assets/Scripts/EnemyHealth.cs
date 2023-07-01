using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public static int health;
    void Start()
    {
        health = 8;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Bullet")
        {
            health--;
            if(health <= 0)
            {
                Destroy(gameObject);
                AudioManager.Instance.PlaySFX("EnemyDead");
                health = 8;
            }
        }
    }
}