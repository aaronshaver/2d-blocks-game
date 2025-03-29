using UnityEngine;
using System.Collections;

public class AIInputProvider : ShipInputProvider
{
    private Vector2 currentInput = Vector2.zero;

    void Start()
    {
        StartCoroutine(UpdateInput());
    }

    IEnumerator UpdateInput()
    {
        while (true)
        {
            currentInput = Random.insideUnitCircle.normalized;
            yield return new WaitForSeconds(1f);
        }
    }

    public override Vector2 GetInput()
    {
        return currentInput;
    }
}
