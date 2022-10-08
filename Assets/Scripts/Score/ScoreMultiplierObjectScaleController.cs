using UnityEngine;

public class ScoreMultiplierObjectScaleController : MonoBehaviour
{
    /*private Vector3 _defaultScale;
    private float _lerpMultiplier = 7.5f;

    private bool _scaleIncrease;
    private bool _scaleDecrease;
    
    private void Start()
    {
        _defaultScale = transform.localScale;
    }

    private void Update()
    {
        if (_scaleIncrease)
            IncreaseTheScale();
        
        else if (_scaleDecrease)
            DecreaseTheScale();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FirstMoney"))
        {
            _scaleDecrease = false;
            _scaleIncrease = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("FirstMoney"))
        {
            _scaleIncrease = false;
            _scaleDecrease = true;
        }
    }

    private void IncreaseTheScale()
    {
        if (transform.localScale != new Vector3(10f, 3f, 4f))
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(10, 3, 4), _lerpMultiplier * Time.deltaTime);

        else
        {
            _scaleIncrease = false;
        }
    }

    private void DecreaseTheScale()
    {
        if (transform.localScale != _defaultScale)
            transform.localScale = Vector3.Lerp(transform.localScale, _defaultScale, _lerpMultiplier * Time.deltaTime);

        else
        {
            _scaleDecrease = false;
        }
    }*/
}
