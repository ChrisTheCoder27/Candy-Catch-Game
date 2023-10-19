using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class Inputs : MonoBehaviour
{
    private static PlayerMovement _movement;
    private static PlayerController _owner;

    public static void BindNewPlayer(PlayerController player)
    {
        _owner = player;
    }

    public static void Init(PlayerController player)
    {
        _movement = new PlayerMovement();
        BindNewPlayer(player);

        _movement.Player.Move.performed += ctx => _owner.Move(ctx.ReadValue<Vector2>());

        PlayMode();
    }

    public static void PlayMode()
    {
        _movement.Player.Enable();
        _movement.UI.Disable();
    }

    public static void SetUIControls()
    {
        _movement.UI.Enable();
        _movement.Player.Disable();
    }

}
