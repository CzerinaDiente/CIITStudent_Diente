using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceSide : MonoBehaviour
{
    bool onGround;
    bool showDiceResults = true;
    bool callFunction = true;
    private float timeOnGround = 0f;
    private float timeOnGroundCheck = 2f;
    public int sideValue;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Ground")
        {
            onGround = true;
            timeOnGround += Time.deltaTime;

            if (timeOnGround > timeOnGroundCheck && showDiceResults)
            {
                if (callFunction)
                {
                    Debug.Log("Value is: " + sideValue);
                    PlayerHop.instance.GoToTile(sideValue);
                    showDiceResults = false;
                    callFunction = false;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag =="Ground")
        {
            onGround = false;
        }
    }

    public bool OnGround()
    {
        return onGround;
    }
}
