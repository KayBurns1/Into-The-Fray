using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 1;
    public Health playerHealth;

    [Header("Sound Effect")]
    public AudioClip hitSound;
    [Range(0f, 1f)]
    public float volume = 1f;

    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerHealth.TakeDamage(damage);

            if (hitSound != null)
            {
                audioSource.PlayOneShot(hitSound, volume);
            }
            else
            {
                Debug.LogWarning("No hitSound assigned on EnemyDamage script.");
            }
        }
    }

}
