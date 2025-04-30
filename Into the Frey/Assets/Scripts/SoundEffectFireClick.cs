using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ClickSoundEffect : MonoBehaviour
{
    [Header("Sound Settings")]
    public AudioClip fireballWhoosh;
    public bool randomizePitch = false;
    public Vector2 pitchRange = new Vector2(0.95f, 1.05f);
    [Range(0f, 1f)]
    public float volume = 1f;

    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.loop = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlaySound();
        }
    }

    public void PlaySound()
    {
        if (fireballWhoosh == null)
        {
            Debug.LogWarning("No AudioClip assigned for fireballWhoosh.");
            return;
        }

        if (randomizePitch)
            audioSource.pitch = Random.Range(pitchRange.x, pitchRange.y);
        else
            audioSource.pitch = 1f;

        audioSource.PlayOneShot(fireballWhoosh, volume);
    }
}
