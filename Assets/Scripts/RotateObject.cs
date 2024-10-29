using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 100f; 
    void Update()
    {
        
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player")) 
        {
            // Hide or destroy the power-up
            gameObject.SetActive(false); // Option 1: Deactivate the power-up
            // Destroy(gameObject); // Option 2: Destroy the power-up
        }
    }

}
