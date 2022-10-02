using UnityEngine;

public class PlayerMovementBoundsController : MonoBehaviour
{
    [SerializeField] private Transform leftBound;
    [SerializeField] private Transform rightBound;
    
    void LateUpdate()
    {
        DeterminePlayerMovementBounds();
    }

    private void DeterminePlayerMovementBounds()
    {
        Vector3 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, leftBound.position.x, rightBound.position.x);
        transform.position = playerPos;
    }
}
