using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Death : MonoBehaviour
{
    [SerializeField] private UnityEvent died;
    private string lastHitter;
    public void CheckDeath(int health)
    {
        
        if (health <= 0)
        {
            //Debug.Log(lastHitter.tag);
            Die();
        }
            
    }


   public void Die()
    {
        //var lastHitter = GetComponent<MagicMissile>().Owner;
        //lastHitter.GetComponent<ScoreBoardPlayer1>().plusPoint();
        gameObject.SetActive(false);
        died.Invoke();
    }
}
