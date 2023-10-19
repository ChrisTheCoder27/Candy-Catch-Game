using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CandySpawn : MonoBehaviour
{
    Rigidbody2D _rb;
    public GameObject candy;
    public Transform candyPos;
    private int _time;

    public string nameCandy;
    public int score;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        //candy = GameObject.Find("Candy (1)");
    }

    void Update()
    {
        /*
        for(int i = 1; i <= 15; i++)
        {
            Spawn();
        }
        UnityEditor.EditorApplication.isPlaying = false;*/
    }

    public void Spawn()
    {
        //_time = Random.Range(1, 4);
        Rigidbody2D rbCandy = Instantiate(candy, candyPos.position, Quaternion.identity).GetComponent<Rigidbody2D>();
    }
}
