using UnityEngine;

public class PlayerIsPushedByObstacle : MonoBehaviour
{
    /*private Rigidbody _rb;
    public static bool isPushed;
    private static float _speedInPushDirection = 600f;
    private float _multiplierSupport = 250f;
    [SerializeField] private CameraShakingController camShakingCont;
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (isPushed)
            PlayerIsPushed();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            camShakingCont._isCameraShaking = true;
            isPushed = true;
        }
    }


    private void PlayerIsPushed()
    {
        _rb.velocity = new Vector3(0f, 0f, - _speedInPushDirection * Time.deltaTime);
        _speedInPushDirection -= Time.deltaTime * _multiplierSupport;

        if (_speedInPushDirection <= 0f)
        {
            isPushed = false;
            _speedInPushDirection = 600f;
        }
    }*/
}
