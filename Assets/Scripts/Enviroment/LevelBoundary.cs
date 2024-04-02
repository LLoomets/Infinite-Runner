using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{

    public static float leftSide = -3.5f;
    public static float rightSide = 3.5f;
    public float internalLeft;
    public float internalRight;

    void Update()
    {
        // uuenda internal level kauguseid
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
