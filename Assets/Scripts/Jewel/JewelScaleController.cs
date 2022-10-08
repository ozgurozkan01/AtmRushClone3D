using UnityEngine;

public class JewelScaleController : MonoBehaviour
{
    /*[HideInInspector] public bool _scaleController;
    private float _lerpMultiplier = 10f;
    private Vector3 _oldScale;
    
    private void Update()
    {
        if (_scaleController)
            IncreaseJewelScale();
        
        else if (!_scaleController)
            DecreaseJewelScale();
        
    }

    
    private void IncreaseJewelScale()
    {
        _oldScale = JewelCollectorController._jewels[0].transform.localScale;
        
        for (int i = JewelCollectorController._jewels.Count - 1; i >= 0; i--)
        {
            JewelCollectorController._jewels[i].gameObject.transform.localScale = Vector3.Lerp(
                JewelCollectorController._jewels[i].gameObject.transform.localScale,
                JewelCollectorController._jewels[i].gameObject.transform.localScale + new Vector3(1, .175f, .5f),
                _lerpMultiplier * Time.deltaTime);
        }
    }

    private void DecreaseJewelScale()
    {
        for (int i = JewelCollectorController._jewels.Count - 1; i >= 0; i--)
        {
            JewelCollectorController._jewels[i].gameObject.transform.localScale = Vector3.Lerp(
                JewelCollectorController._jewels[i].gameObject.transform.localScale,
                _oldScale,
                _lerpMultiplier * Time.deltaTime);
        }
    }*/
}
