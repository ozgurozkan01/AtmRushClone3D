using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class JewelSeparationController : MonoBehaviour
{
    [SerializeField] private JewelStoredInAtmMachine jewelStoredInAtmMachine;
    [SerializeField] private JewelMovementSmoothlyController jewelMoveCont;
    
    private void Start()
    {
        jewelStoredInAtmMachine = GetComponent<JewelStoredInAtmMachine>();
        jewelMoveCont = GetComponent<JewelMovementSmoothlyController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Atm"))
        {
            JewelSeparation(JewelCollectorController._jewels.IndexOf(gameObject));
            jewelStoredInAtmMachine.CheckJewelType();
            Destroy(gameObject);
        }
        
        else if (other.gameObject.CompareTag("Obstacle"))
        {
            JewelSeparation(JewelCollectorController._jewels.IndexOf(gameObject));
            Destroy(gameObject);
        }
        
        else if (other.gameObject.CompareTag("DirectionChanger"))
        {
            JewelCollectorController._jewels.Remove(gameObject);
            jewelMoveCont._isMovingDependently = false;
            
            if (JewelCollectorController._jewels.Count == 0)
            {
                PlayerMovement.isMoving = false;
            }
        }
    }


    private void JewelSeparation(int jewelIndex)
    {
        if (jewelIndex >= 0)
        {
            DetermineTheLastJewel(jewelIndex);
            
            if (jewelIndex == JewelCollectorController._jewels.Count - 1)
            {
                JewelCollectorController._jewels.Remove(JewelCollectorController._jewels[jewelIndex]);
            }

            else
            {
                for (int i = JewelCollectorController._jewels.Count - 1; i > jewelIndex; i--)
                { 
                    JewelCollectorController._jewels[i].gameObject.tag = "CollectableMoney";
                    JewelCollectorController._jewels[i].transform.position = new Vector3(
                        Random.Range(-5, 5f),
                        JewelCollectorController._jewels[i].transform.position.y,
                        JewelCollectorController._jewels[i].transform.position.z + Random.Range(5f, 9f));
            
            
                    Destroy(JewelCollectorController._jewels[i].GetComponent<JewelMovementSmoothlyController>());
                    Destroy(JewelCollectorController._jewels[i].GetComponent<JewelCollectorController>());

                    JewelCollectorController._jewels[i].GetComponent<Collider>().isTrigger = true;
                    JewelCollectorController._jewels.Remove(JewelCollectorController._jewels[i]);
                }
            
                JewelCollectorController._jewels.Remove(gameObject);
            }

        }
    }

    private void DetermineTheLastJewel(int index)
    {
        if (index == 0)
            JewelCollectorController._lastObject = null;
        
        
        else if (index > 0)
            JewelCollectorController._lastObject = JewelCollectorController._jewels[index - 1];

    }
}
