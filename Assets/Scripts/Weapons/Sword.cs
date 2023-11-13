using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] private int attackDamage = 1;

    [Header("References")] 
    private Enemy _enemyScript;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            _enemyScript = other.GetComponent<Enemy>();
            _enemyScript.Enemy_Take_Damage(attackDamage);
        }
    }
}
