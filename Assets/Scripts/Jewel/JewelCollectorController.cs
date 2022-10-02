using System;
using System.Collections.Generic;
using UnityEngine;

public class JewelCollectorController : MonoBehaviour
{
    /*public static List<GameObject> _jewels = new List<GameObject>();
    private static GameObject _lastObject;
    [SerializeField] private GameObject player;

    private void Start()
    {
        player = GetComponent<GameObject>();
        player = GameObject.Find("Player");
    }

    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CollectableMoney"))
        {
            CollectTheJewels(other.gameObject);
        }
    }

    private void CollectTheJewels(GameObject jewel)
    {
        jewel.gameObject.tag = "CollectedMoney";
        jewel.gameObject.GetComponent<Collider>().isTrigger = false;
        jewel.gameObject.AddComponent<JewelCollectorController>();
        jewel.gameObject.AddComponent<JewelSeparationController>();
        jewel.gameObject.AddComponent<JewelMovementSmoothlyController>();
        
        if (_jewels.Count == 0)
            jewel.gameObject.GetComponent<JewelMovementSmoothlyController>().connectedObject = player.transform;
        
        
        else if (_jewels.Count != 0)
            jewel.gameObject.GetComponent<JewelMovementSmoothlyController>().connectedObject = _jewels[_jewels.Count - 1].transform;
        
        _lastObject = jewel.gameObject;
        _jewels.Add(_lastObject);
    }*/
}
