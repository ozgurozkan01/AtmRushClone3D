using System;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rb;
    public float speedZ;
    [SerializeField] private float speedX;
    [SerializeField] private float speedMultiplier = 100f;
    public static bool isMoving = true;
    [SerializeField] private PlayerPositionController playerPosCont;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (!PlayerIsPushedByObstacle.isPushed)
        {
            if (isMoving)
                GetMovementInput();
        
            else if(!isMoving)
                playerPosCont.ArrangePlayerPosToCenter();
        }
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
