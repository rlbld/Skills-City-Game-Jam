using UnityEngine;

public class RotateObject : MonoBehaviour
{

    public AudioClip pickupSound; // Sound to play on pickup
    private AudioSource audioSource; // Reference to the AudioSource
    public float rotationSpeed = 100f;


    private void Start()
    {
        // Get the AudioSource component attached to the power-up
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player")) 
        {

            // Play the pickup sound
            PlayPickupSound();

            // Hide or destroy the power-up
            gameObject.SetActive(false); // Option 1: Deactivate the power-up
            // Destroy(gameObject); // Option 2: Destroy the power-up
        }
    }

    private void PlayPickupSound()
    {
        if (audioSource != null && pickupSound != null)
        {
            audioSource.PlayOneShot(pickupSound); // Play the sound once
        }
    }

}
