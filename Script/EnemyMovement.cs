using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private UnityEvent<Vector2> moveDirection;

    private void FixedUpdate()
    {
        var player1Position = PlayerManager.P1Posistion;
        var player2Position = PlayerManager.P2Posistion;
        var position = (Vector2)transform.position;
        var direction1 = player1Position - position;
        var direction2 = player2Position - position;

        var direction = player1Position - position;
        if (direction1.sqrMagnitude < direction2.sqrMagnitude)
        {
            direction =  player1Position - position;
        } // if 
        else
        {
            direction = player2Position - position;
        } // else 
        direction.Normalize();
        var targetPosition = position + direction;

        if (position == targetPosition) return;

        rb.DOMove(targetPosition, speed).SetSpeedBased();
        moveDirection.Invoke(direction);
    } // fixupdate
}


/*        var direction1 = player1Position - position;
        var direction2 = player1Position - position;

        var direction = player1Position - position;
        if (direction1.sqrMagnitude < direction2.sqrMagnitude)
        {
            direction =  player1Position - position;
        } // if 
        else
        {
            direction = player2Position - position;
        } // else */