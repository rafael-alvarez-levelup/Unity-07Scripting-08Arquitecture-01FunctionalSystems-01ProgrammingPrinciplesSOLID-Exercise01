using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    [SerializeField] private SpeedData speedData;

    public void Move(float x)
    {
        Move(x, 0, 0);
    }

    public void Move(float x, float y)
    {
        Move(x, y, 0);
    }

    public void Move(float moveX, float moveY, float moveZ)
    {
        Vector3 direction = new Vector3(moveX, moveY, moveZ);
        transform.Translate(direction * speedData.Speed * Time.deltaTime);
    }
}