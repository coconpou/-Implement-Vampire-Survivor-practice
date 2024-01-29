using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Timers;

public class MagicMissile : MonoBehaviour
{
    [SerializeField] private MissileCreate creator;
    [SerializeField] private UnityEvent missileLaunch;
    public Transform Owner;
  
    private void LaunchMissile()
    {
        creator.CreateMisslie();
        //Debug.Log(Owner.name);
        missileLaunch.Invoke();
    }


    private void Awake()
    {
        TimersManager.SetLoopableTimer(this, 1, LaunchMissile);
    }
}
