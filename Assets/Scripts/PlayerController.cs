using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 _move;

    [SerializeField] private float speed;

    void Start()
    {
        Inputs.Init(this);
    }

    void Update()
    {
        transform.Translate(Vector2.right * (speed * Time.deltaTime * _move.x), Space.Self);
    }

    public void Move(Vector2 direction)
    {
        _move = direction;
    }
}
