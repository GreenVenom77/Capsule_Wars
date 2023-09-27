using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] private int health = 3;
    [SerializeField] private int attackDamage;
    
    [Header("References")]
    private GameObject target;
    private NavMeshAgent _agent;
    private Game_Manager _gameManager;
    private int randomPlayer;
    
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _gameManager = FindObjectOfType<Game_Manager>();
        Target();
    }

    void Update()
    {
        _agent.destination = target.transform.position;
    }

    public void Enemy_Take_Damage(int damage)
    {
        health -= damage;
    }
    
    private void Target()
    {
        randomPlayer = Random.Range(0, _gameManager.Players.Length);
        target = _gameManager.Players[randomPlayer];
        Debug.Log(target);
    }
}
