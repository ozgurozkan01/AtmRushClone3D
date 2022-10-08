using UnityEngine;

public class JewelUpgradeController : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.CompareTag("UpgradeJewel"))
         UpgradeJewel();
   }

   private void UpgradeJewel()
   {
      if (gameObject.CompareTag("CollectedMoney"))
      {
         gameObject.GetComponent<Renderer>().material.color = Color.yellow;
         gameObject.tag = "CollectedGold";
      }
      
      else if (gameObject.CompareTag("CollectedGold"))
      {
         gameObject.GetComponent<Renderer>().material.color = Color.magenta;
         gameObject.tag = "CollectedDiamond";
      }
   }
}
