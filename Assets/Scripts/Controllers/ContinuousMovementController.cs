using UnityEngine;

public class ContinuousMovementController : MonoBehaviour
{
    private MovementBehaviour movementBehaviour;

    private void Awake()
    {
        movementBehaviour = GetComponent<MovementBehaviour>();
    }

    private void Update()
    {
        movementBehaviour.Move(0, -1f);
    }
}