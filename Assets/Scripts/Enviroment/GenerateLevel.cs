using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{

    public GameObject[] section; // Section-te array, mida saab genereerida
    public int zPos = 52;
    public bool creatingSection = false;
    public int secNum;

    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());

        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        // uue section-i positsioon
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 52;
        yield return new WaitForSeconds(8);
        // generatsioon lõpule viidud
        creatingSection = false;
    }
}
