using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndRunSequence : MonoBehaviour
{
    public GameObject liveCoins;
    public GameObject liveDis;
    public GameObject endScreen;
    public GameObject fadeOut;
    void Start()
    {
        StartCoroutine(EndSequence());
    }

    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(3);

        // peata live display
        liveCoins.SetActive(false);
        liveDis.SetActive(false);
        // endscreen käima
        endScreen.SetActive(true);

        yield return new WaitForSeconds(3);
        fadeOut.SetActive(true);

        yield return new WaitForSeconds(2);
        // mainMenu stseen
        SceneManager.LoadScene(0);
    }
}
