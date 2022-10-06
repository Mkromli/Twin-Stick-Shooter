using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Image healthBar;
    [SerializeField] public float health = 100;
    [SerializeField] private float invincibilityLength;
    public bool invincible = false;
    private int invincibleTimer;

    void Update()
    {
     if (health <= 0)
     {
            Destroy(gameObject);
     }

     healthBar.fillAmount = health / 100;

        if (invincible == true)
     {
            invincibleTimer += 1;
            if (invincibleTimer >= invincibilityLength)
            {
                invincible = false;

            }

     }

    }
}
