using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDistance : MonoBehaviour
{

    public GameObject disDisplay;
    public GameObject disEndDisplay;
    public int disRun;
    public bool addingDis = false;

    void Update()
    {
        if (addingDis == false)
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }
    }

    IEnumerator AddingDis()
    {
        disRun += 1;
        // live display uuendamine
        disDisplay.GetComponent<Text>().text = "" + disRun;
        // end display uuendamine
        disEndDisplay.GetComponent<Text>().text = "" + disRun;

        yield return new WaitForSeconds(0.35f);
        addingDis = false;
    }
}
