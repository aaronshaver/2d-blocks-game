using UnityEngine;

public abstract class ShipInputProvider : MonoBehaviour
{
    // Returns an input vector for movement
    public abstract Vector2 GetInput();
}
