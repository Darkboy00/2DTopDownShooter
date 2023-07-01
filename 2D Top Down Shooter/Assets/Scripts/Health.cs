using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(GameControl.health < 3)
        {
            GameControl.health += 1;
            Destroy(gameObject);
            AudioManager.Instance.PlaySFX("Heartbeat");
        }
    }
}