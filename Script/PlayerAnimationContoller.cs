using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimationContoller : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private string walkState;
    [SerializeField] private string idleState;
    [SerializeField] private string attackState;

    public void Move(InputAction.CallbackContext context )
    {
        var direction = context.ReadValue<Vector2>();
        if( direction == Vector2.zero )
        {
            animator.Play(idleState);
        } // if
        else
        {
            animator.Play(walkState); 
        } // else
        if ( direction.x > 0 )
        {
            spriteRenderer.flipX = false;
        } // if
        else
        {
            spriteRenderer.flipX = true;
        } // else 
    } // move

    public void Attack()
    {
        animator.Play(attackState);
    } // attack
}
