using System.Collections;
using UnityEngine;

public class ScoreMultipllierController : MonoBehaviour
{
    [SerializeField] private GameObject originalMoneyPrefab;
    private float moneyHeight = 1.2f;
    [HideInInspector] public bool _shouldScoreCheck;
    
    private void Update()
    {
        if (_shouldScoreCheck)
        {
            StartCoroutine(FindScoreMultiplier());
            _shouldScoreCheck = false;
        }
    }

    IEnumerator FindScoreMultiplier()
    {
        yield return new WaitForSeconds(2f);
        
        for (int i = 0; i < JewelStoredInAtmMachine.storedJewelValue; i++)
        {
            yield return new WaitForSeconds(0.02f);
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y + .375f,
                transform.position.z);
            
            GameObject newMoney = Instantiate(originalMoneyPrefab,
                transform.position,
                transform.rotation);
            
            newMoney.transform.SetParent(gameObject.transform);
            newMoney.transform.localPosition = new Vector3(0f, -moneyHeight, 0f);
            moneyHeight += .375f;

            if (i == 0)
            {
                newMoney.tag = "FirstMoney";
                newMoney.GetComponent<Collider>().isTrigger = true;
            }
        }
    }
}
