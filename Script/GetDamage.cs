using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class GetDamage : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private UnityEvent damaged;
    private Color _defaultColor;
    public void TakeDamage( int damage )
    {
        health.DecreasingHealth(damage);
        spriteRenderer.DOColor(Color.red, 0.2f).SetLoops(2,LoopType.Yoyo).ChangeStartValue(_defaultColor);
        damaged.Invoke();
    }

    private void Awake()
    {
        _defaultColor = spriteRenderer.color;
    }
} // get dmg
