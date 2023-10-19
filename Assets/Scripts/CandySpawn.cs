using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CandySpawn : MonoBehaviour
{
    Rigidbody2D _rb;
    public GameObject[] candies;
    private Vector3 candyPos;
    private int _time;

    public string nameCandy;
    public int score;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Time_Between_Candy());
    }

    void Update()
    {

        for(int i = 1; i <= 15; i++)
        {
            Spawn();
        }
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void Spawn()
    {
        // Chooses random x position of the candy that will be dropped and sets y position to be 7.0, the top of the screen
        int num = Random.Range(0, 6);
        candyPos = new Vector3(Random.Range(-13, 14), 7, 0);
        Rigidbody2D rbCandy = Instantiate(candies[num], candyPos, Quaternion.identity).GetComponent<Rigidbody2D>();
    }

    IEnumerator Time_Between_Candy()
    {
        _time = Random.Range(1, 4);
        yield return new WaitForSeconds(_time);
        Spawn();
    }
}
