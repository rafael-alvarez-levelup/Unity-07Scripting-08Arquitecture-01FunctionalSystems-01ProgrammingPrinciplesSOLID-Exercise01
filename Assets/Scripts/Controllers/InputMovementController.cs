using UnityEngine;

public class InputMovementController : MonoBehaviour
{
    private MovementBehaviour movementBehaviour;
    private EngineBehaviour engineBehaviour;

    private void Awake()
    {
        movementBehaviour = GetComponent<MovementBehaviour>();
        engineBehaviour = GetComponent<EngineBehaviour>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        if (horizontal != 0)
        {
            movementBehaviour.Move(horizontal);
        }

        engineBehaviour.Toggle(horizontal != 0);
    }
}