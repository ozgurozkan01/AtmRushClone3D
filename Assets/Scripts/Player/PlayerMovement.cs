using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rb;
    public float speedZ;
    [SerializeField] private float speedX;
    [SerializeField] private float speedMultiplier = 100f;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetMovementInput();
    }

    private void GetMovementInput()
    {
        float directionHorizontal = Input.GetAxis("Horizontal");
        Move(directionHorizontal);
    }
    
    private void Move(float dirHorizontal)
    {
        _rb.velocity = new Vector3(
            dirHorizontal * speedX * Time.deltaTime * speedMultiplier,
            0f,
            speedZ * Time.deltaTime * speedMultiplier
            );
    }
}
