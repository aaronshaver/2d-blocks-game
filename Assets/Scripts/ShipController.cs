using UnityEngine;

public class ShipController : MonoBehaviour
{
    private Rigidbody2D rb;
    private ShipInputProvider inputProvider;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        inputProvider = GetComponent<ShipInputProvider>();
        if (inputProvider == null)
        {
            Debug.LogError("No ShipInputProvider found on " + gameObject.name);
        }
    }

    void Update()
    {
        if (inputProvider == null) return;

        // Get input from the current input provider
        Vector2 input = inputProvider.GetInput();

        // Aggregate the acceleration values from all SpeedBlock components in child objects
        float totalAcceleration = 0f;
        SpeedBlock[] speedBlocks = GetComponentsInChildren<SpeedBlock>();
        foreach (SpeedBlock sb in speedBlocks)
        {
            totalAcceleration += sb.acceleration;
        }

        // Apply force to the ship's Rigidbody2D based on input and total acceleration
        rb.AddForce(input * totalAcceleration);
    }
}
