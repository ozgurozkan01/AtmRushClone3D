using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class JewelSeparationController : MonoBehaviour
{
    /*[SerializeField] private PlayerMovement playerMovement;

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Atm"))
        {
        }
        
        else if (other.gameObject.CompareTag("Obstacle"))
        {
            JewelSeparation(JewelCollectorController._jewels.IndexOf(gameObject));
        }
    }


    private void JewelSeparation(int jewelIndex)
    {
        if (jewelIndex == JewelCollectorController._jewels.Count - 1)
        {
            JewelCollectorController._jewels.Remove(JewelCollectorController._jewels[jewelIndex]);
            Destroy(gameObject);
        }
        
        else if (jewelIndex < 0)
        {
            Debug.Log(jewelIndex);
            playerMovement.speedZ = 0f;
        }
        
        else
        {            
            for (int i = JewelCollectorController._jewels.Count - 1; i > jewelIndex; i--)
            {
                JewelCollectorController._jewels[i].gameObject.tag = "CollectableMoney";
                JewelCollectorController._jewels[i].transform.position = new Vector3(
                    JewelCollectorController._jewels[i].transform.position.x + Random.Range(3f, 6f),
                    JewelCollectorController._jewels[i].transform.position.y,
                    JewelCollectorController._jewels[i].transform.position.z + Random.Range(5f, 9f));
            
            
            
                Destroy(JewelCollectorController._jewels[i].GetComponent<JewelCollectorController>());
                Destroy(JewelCollectorController._jewels[i].GetComponent<JewelMovementSmoothlyController>());
                JewelCollectorController._jewels[i].GetComponent<Collider>().isTrigger = true;
                JewelCollectorController._jewels.Remove(JewelCollectorController._jewels[i]);
            }
            JewelCollectorController._jewels.Remove(JewelCollectorController._jewels[jewelIndex]);
            Destroy(gameObject);
        }
    }*/
}
