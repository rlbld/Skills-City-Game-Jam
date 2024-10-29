using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float rotationSpeed = 100f;
    public float moveInterval = 2f; // Time interval for moving to a new position
    public float moveDistance = 3f;  // Half the side length of the area (3m for a 6m x 6m area)

    [SerializeField] private AudioSource gostSound;

    private Vector3 startPosition; // Store initial position

    private void Start()
    {
        startPosition = transform.position; // Set the starting position

        // Start the coroutine for random movement
        StartCoroutine(MoveRandomly());
    }

    void Update()
    {
        // Rotate the object
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }

    

    private System.Collections.IEnumerator MoveRandomly()
    {
        while (true)
        {
            // Generate a random position within a square area of 6m x 6m around the start position
            Vector3 randomPosition = new Vector3(
                startPosition.x + Random.Range(-moveDistance, moveDistance),
                startPosition.y, // Keep the current height
                startPosition.z + Random.Range(-moveDistance, moveDistance)
            );

            // Smoothly move to the new position over the moveInterval duration
            float elapsedTime = 0f;
            Vector3 startPos = transform.position;
            while (elapsedTime < moveInterval)
            {
                transform.position = Vector3.Lerp(startPos, randomPosition, (elapsedTime / moveInterval));
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            // Ensure the object reaches the exact new position
            transform.position = randomPosition;

            // Wait for the specified move interval before moving again
            yield return new WaitForSeconds(moveInterval);
        }
    }

    // Optional: Visualize the movement bounds in the Scene view
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(startPosition, new Vector3(moveDistance * 2, 0, moveDistance * 2));
    }
}
