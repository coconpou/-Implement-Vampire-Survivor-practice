using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyAnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private string moveState;
    public void Move(Vector2 direction)
    {
        if(direction.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        } // if
        else
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        } // else

        animator.Play(moveState);

    }
}
