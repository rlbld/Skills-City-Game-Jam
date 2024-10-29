using UnityEngine;

public class RotateObject : MonoBehaviour
{

    public float rotationSpeed = 100f;

    [SerializeField] private AudioSource pickupSound; // Reference to the AudioSource component


    void Update()
    {
        
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player")) 
        {
            // Play the pickup sound
            if (pickupSound != null)
            {
                pickupSound.Play();
            }

            // Hide or destroy the power-up
            gameObject.SetActive(false); // Option 1: Deactivate the power-up
            // Destroy(gameObject); // Option 2: Destroy the power-up
        }
    }
  
}
