using UnityEngine;

public class ShipController : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input from WASD (or arrow keys)
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

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
