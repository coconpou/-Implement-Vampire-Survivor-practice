using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Transform player2Transform;

    private static PlayerManager _instance;
    public static Vector2 P1Posistion
    {
        get { return _instance.playerTransform.position; }
    }

    public static Vector2 P2Posistion
    {
        get { return _instance.player2Transform.position; }
    }

    private void Awake()
    {
        _instance = this;
    }
} // player manager
