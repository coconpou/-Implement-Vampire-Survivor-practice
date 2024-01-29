using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Animator : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private string walkState;
    [SerializeField] private string idleState;
    [SerializeField] private string attackState;

    public void Move(Vector2 direction)
    {
        //var direction = context.ReadValue<Vector2>();
        
        if (direction.x > 0)
        {
            spriteRenderer.flipX = false;
        } // if
        else
        {
            spriteRenderer.flipX = true;
        } // else 
        animator.Play(walkState);
    } // move

    public void Attack()
    {
        animator.Play(attackState);
    } // attack
}
