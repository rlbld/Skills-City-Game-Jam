using UnityEngine;

public class RotateParentInPlace : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 30f;

    private Vector3 initialPosition;

    void Start()
    {
        // Store the initial position to prevent movement
        initialPosition = transform.position;
    }

    void Update()
    {
        // Rotate the parent only around its local Y-axis
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.Self);

        // Keep the parent position constant
        transform.position = initialPosition;
    }
}