
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private UnityEvent<int> healthBarChanged;

    public int Value
    {
        get { return health; }
    } // value

    public void DecreasingHealth( int damage )
    {
        health = health - damage;
        healthBarChanged.Invoke(health);
    }
} // health
