using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerPositionController : MonoBehaviour
{
    /*[SerializeField] [Range(0, 10)] private float lerpMultiplier;
    [SerializeField] private Transform scoreCheckPos;
    [SerializeField] private PlayerRotationController playerRotCont;
    [SerializeField] private FinishCollisionController finishColCont;
    [SerializeField] private ScoreMultipllierController scoreCont;

    private void Update()
    {
        if (finishColCont.isPassedFinishLine)
        {
            StartCoroutine(ChangePlayerPosAndRotate());
            finishColCont.isPassedFinishLine = false;
        }
    }

    public void ArrangePlayerPosToCenter()
    {
        transform.position = Vector3.Lerp(
            transform.position,
            new Vector3(0f, transform.position.y, transform.position.z),
            lerpMultiplier * Time.deltaTime);
    }

    private void ChangePlayerPosForCalcTheScoreMultiplier()
    {
        transform.position = scoreCheckPos.transform.position;
    }

    IEnumerator ChangePlayerPosAndRotate()
    {
        yield return new WaitForSeconds(2.2f);
        ChangePlayerPosForCalcTheScoreMultiplier();
        playerRotCont.PlayerRotatingOppositeDirection();
        scoreCont._shouldScoreCheck = true;
    }*/
}
