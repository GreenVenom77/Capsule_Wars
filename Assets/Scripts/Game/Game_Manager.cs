using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    [Header("References")] 
    [SerializeField] public List<GameObject> Players;
    [SerializeField] private GameObject Player_Spawn_Point;
    [SerializeField] private GameObject Enemy;
    [SerializeField] private GameObject[] Enemy_Spawn_Points;
    [SerializeField] public List<GameObject> Enemies;
    private GameObject Instantiated_Enemy;

    [Header("Variables")]
    private int randomSpawn;
    private int enemyCounter = 0;
    private int maxEnemies = 5;

    void Awake()
    {
        Players = new List<GameObject>(GameObject.FindGameObjectsWithTag("Player"));
    }
    
    void Start()
    {
        InvokeRepeating("Enemy_Spawn", 2f, 1f);
        InvokeRepeating("Checking_Nulls", 5f, 0.2f);
    }

    void Update()
    {
        
    }
    
    private void Checking_Nulls()
    {
        Players.RemoveAll(item => item == null);
        Enemies.RemoveAll(item => item == null);
    }

    #region -------------------Enemy Spawn-------------------

        private void Enemy_Spawn()
        {
            if(enemyCounter != maxEnemies && Enemies.Count >= 0){
                while (enemyCounter < maxEnemies)
                {
                    randomSpawn = Random.Range(0, Enemy_Spawn_Points.Length - 1);
                    Instantiated_Enemy = Instantiate(Enemy, Enemy_Spawn_Points[randomSpawn].transform.position, Quaternion.identity);
                    Enemies.Add(Instantiated_Enemy);
                    enemyCounter++;
                }
            }
            else if (enemyCounter == maxEnemies && Enemies.Count <= 0)
            {
                enemyCounter = 0;
                maxEnemies +=4;
            }
        }

    #endregion
}
