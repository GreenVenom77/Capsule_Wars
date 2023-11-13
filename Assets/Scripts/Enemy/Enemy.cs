using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] private int health = 3;
    [SerializeField] private int attackDamage = 2;
    private int score = 1;
    
    [Header("References")]
    private GameObject target;
    private NavMeshAgent _agent;
    private Game_Manager _gameManager;
    private int randomPlayer;
    
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _gameManager = FindObjectOfType<Game_Manager>();
        Invoke("Target", 1f);
    }

    void Update()
    {
        if (target)
        {
            _agent.destination = target.transform.position;
        }
        else
        {
            StartCoroutine(Retargeting());
        }
    }

    public void Enemy_Take_Damage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            _gameManager.Recount_Score(score);
            Destroy(gameObject);
        }
    }
    
    private void Target()
    {
        if (!target && _gameManager.Players.Count != 0)
        {
            randomPlayer = Random.Range(0, _gameManager.Players.Count);
            target = _gameManager.Players[randomPlayer];
            //Debug.Log(target);
        }
    }

    IEnumerator Retargeting()
    {
        yield return new WaitForSeconds(0.3f);
        Target();
    }
}
