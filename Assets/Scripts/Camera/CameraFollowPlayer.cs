using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float lerpMultiplier;
    private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - player.transform.position;
    }

    void FixedUpdate()
    {
        CameraMovement();
    }

    private void CameraMovement()
    {
        transform.position = Vector3.Lerp(
            transform.position,
            player.transform.position + _offset,
            lerpMultiplier * Time.deltaTime);
    }
}
