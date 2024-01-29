using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSFX : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip gameOverClip;
    [SerializeField] private AudioClip magicMissileLuanchClip;
    [SerializeField] private AudioClip takeDamageClip;

    public void PlayGameOver()
    {
        audioSource.PlayOneShot(gameOverClip);
    }
    public void PlayMagicMissileLuanch()
    {
        audioSource.PlayOneShot(magicMissileLuanchClip);
    }
    public void PlayTakeDamageClip()
    {
        audioSource.PlayOneShot(takeDamageClip);
    }

}
