using System;
using UnityEngine;

public class JewelMovementSmoothlyController : MonoBehaviour
{/*
    [HideInInspector] public Transform connectedObject; 
    private float lerpMultiplier = 15f;
    [HideInInspector] public bool _isMovingDependently = true;
    private float _speedX = 10f;
    
    void FixedUpdate()
    {
        JewelMovement();
    }

    private void JewelMovement()
    {
        if (_isMovingDependently)
        {
            if (connectedObject != null)
            {

                if (JewelCollectorController._jewels.Count == 0)
                {
                    transform.position = new Vector3(
                        Mathf.Lerp(transform.position.x, connectedObject.position.x, lerpMultiplier * Time.deltaTime),
                        connectedObject.position.y,
                        connectedObject.position.z + 3f);
                }
            
                else if (JewelCollectorController._jewels.Count > 0)
                {
                    transform.position = new Vector3(
                        Mathf.Lerp(transform.position.x, connectedObject.position.x, lerpMultiplier * Time.deltaTime),
                        connectedObject.position.y,
                        connectedObject.position.z + 1.25f);
                }
            }   
        }
        
        else if (!_isMovingDependently)
        {
            transform.Translate(Vector3.left * (_speedX * Time.deltaTime));
        }
    }*/
}
