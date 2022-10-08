using UnityEngine;

public class PlayerRotationController : MonoBehaviour
{
    public void PlayerRotatingOppositeDirection()
    {
        transform.rotation = new Quaternion(0f, 180f, 0f, 0f);
    }
}
