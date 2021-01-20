using UnityEngine;

public class DestroyOnCollisionController : MonoBehaviour
{
    private DestroyBehaviour destroyBehaviour;

    private void Awake()
    {
        destroyBehaviour = GetComponent<DestroyBehaviour>();
    }

    private void OnTriggerEnter()
    {
        destroyBehaviour.Destroy();
    }
}