using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{

    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject fadeIn;
    void Start()
    {
        StartCoroutine(CounSequence());
    }

    IEnumerator CounSequence()
    {
        yield return new WaitForSeconds(1);
        countDown3.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown2.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown1.SetActive(true);
        yield return new WaitForSeconds(1);


        PlayerMove.canMove = true;
    }
}
