using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableControl : MonoBehaviour
{

    public static int coinCount;
    public GameObject coinCountDisplay;
    public GameObject coinEndDisplay;

    void Update()
    {
        // live coinDisplay uuendamine
        coinCountDisplay.GetComponent<Text>().text = "" + coinCount;
        // end coinDisplay uuendamine
        coinEndDisplay.GetComponent<Text>().text = "" + coinCount;

    }
}
