using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileCreate : MonoBehaviour
{
    [SerializeField] private GameObject missile;
    [SerializeField] private Transform playerTransform;
    [SerializeField] public string playerTag;
    public void CreateMisslie()
    {
        missile.tag = playerTag;
        Instantiate(missile, playerTransform.position, Quaternion.identity);
    }

}
