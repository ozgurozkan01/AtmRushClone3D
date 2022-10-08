using UnityEngine;

public class ObstacleMoveLeftAndRight : MonoBehaviour
{
    private float _lerpMultiplier = 5f;

    [SerializeField] private Transform pointA;
    [SerializeField] private Transform pointB;
    
    private bool _moveAtoB = true;
    private bool _moveBtoA;

    private void Update()
    {
        ObstacleMove();
    }

    private void ObstacleMove()
    {
        if (_moveAtoB)
        {
            if (Vector3.Distance(transform.position, pointB.position) > .1f)
                transform.position = Vector3.Lerp(transform.position, pointB.position, _lerpMultiplier * Time.deltaTime);
            
            
            else
            {
                _moveBtoA = true;
                _moveAtoB = false;
            }
        }
        
        else if (_moveBtoA)
        {
            if (Vector3.Distance(transform.position, pointA.position) > .1f)
                transform.position = Vector3.Lerp(transform.position, pointA.position, _lerpMultiplier * Time.deltaTime);       
            
            else
            {
                _moveBtoA = false;
                _moveAtoB = true;
            }
        }
    }
}
