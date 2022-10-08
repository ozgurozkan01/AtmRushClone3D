using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class CameraShakingController : MonoBehaviour
{
    [HideInInspector] public bool _isCameraShaking;

    private void LateUpdate()
    {
        if (_isCameraShaking)
        {
            CameraShakingCall();
            _isCameraShaking = false;
        }
    }

    IEnumerator CameraShaking(float duration, float shakeMagnitude)
    {
        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-2f, 2f) * shakeMagnitude;
            float y = Random.Range(-2f, 2f) * shakeMagnitude;

            transform.localPosition = new Vector3(x, y, transform.localPosition.z);
            
            elapsed += Time.deltaTime;

            yield return null;
        }
        
        transform.localPosition = Vector3.zero;
    }

    public void CameraShakingCall()
    {
        StartCoroutine(CameraShaking(0.22f, 0.7f));
    }
}
