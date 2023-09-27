using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    [SerializeField] public GameObject[] Players;

    void Awake()
    {
        Players = GameObject.FindGameObjectsWithTag("Player");
    }

    void Update()
    {
        
    }
}
