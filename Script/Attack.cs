using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Timers;

public class Attack : MonoBehaviour
{
    [SerializeField] private string targetTag;
    [SerializeField] private UnityEvent afterAttack;
    
    private bool _canAttack = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DealDamage(collision);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        DealDamage(other);
    }
    private void CanAttack()
    {
        _canAttack = true;
    }
    private void DealDamage( Collider2D other )
    {
        if (other.CompareTag(targetTag))
        {
            if (!_canAttack) return;
            /*if(other.GetComponent<MagicMissile>().Owner.name != null)
            {
                var lastHitter = other.GetComponent<MagicMissile>().Owner.name;
                Debug.Log("lastHitter is " + lastHitter);
            }*/

            var getDamage = other.GetComponent<GetDamage>();
            getDamage.TakeDamage(1);
            TimersManager.SetTimer(this, 1, CanAttack);
            _canAttack = false;
            afterAttack.Invoke();
        }
    }

}
