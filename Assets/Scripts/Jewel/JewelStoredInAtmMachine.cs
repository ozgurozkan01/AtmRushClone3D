using TMPro;
using UnityEngine;

public class JewelStoredInAtmMachine : MonoBehaviour
{
    public static int storedJewelValue;
    private TextMeshPro[] _textMeshPros;
    
    private void Start()
    {
        _textMeshPros = GetComponents<TextMeshPro>();
        _textMeshPros = FindObjectsOfType<TextMeshPro>();
    }

    public void CheckJewelType()
    {
        if (gameObject.CompareTag("CollectedMoney"))
            storedJewelValue++;
        
        else if (gameObject.CompareTag("CollectedGold"))
            storedJewelValue += 2;
        
        else if (gameObject.CompareTag("CollectedDiamond"))
            storedJewelValue += 4;
        
        IncreaseJewelValueOfText();
    }

    private void IncreaseJewelValueOfText()
    {
        for (int i = 0; i < _textMeshPros.Length; i++)
        {
            if (_textMeshPros[i].gameObject.CompareTag("StoredJewel"))
                _textMeshPros[i].text = storedJewelValue.ToString();
        }
    }
}
