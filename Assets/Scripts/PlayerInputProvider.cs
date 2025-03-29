using UnityEngine;

public class PlayerInputProvider : ShipInputProvider
{
    public override Vector2 GetInput()
    {
        return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
}
