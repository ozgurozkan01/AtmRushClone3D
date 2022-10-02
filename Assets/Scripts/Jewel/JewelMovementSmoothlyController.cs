using UnityEngine;

public class JewelMovementSmoothlyController : MonoBehaviour
{
    [HideInInspector] public Transform connectedObject; 
    private float lerpMultiplier = 15f;
    void FixedUpdate()
    {
        JewelMovement();
    }

    private void JewelMovement()
    {
        transform.position = new Vector3(
            Mathf.Lerp(transform.position.x, connectedObject.position.x, lerpMultiplier * Time.deltaTime),
                connectedObject.position.y,
                connectedObject.position.z + 1.25f);
    }
}
