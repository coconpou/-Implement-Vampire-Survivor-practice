using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;

public class RandomMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    private Vector2 direction;

    public void Awake()
    {
        transform.position = new Vector2(Random.Range(-3f, 15f), Random.Range(-4f, 0.8f));

        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;

    } // Move()

    private void FixedUpdate()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (transform.position.x < -3f || transform.position.x > 15f)
        {
            direction.x = -direction.x;
            /*if (direction.x < 0)
            {
                transform.rotation = Quaternion.Euler(0,  180, 0);
            } // if

            else {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            } // else */
        } // if
        if (transform.position.y < -4f || transform.position.y > 4f)
        {
            direction.y = -direction.y;
 
        }//if
    }
}
