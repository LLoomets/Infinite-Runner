using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFX;
    
    // kutsutakse välja kui teine collider(player) puutub kokku coiniga
    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        CollectableControl.coinCount += 1;
        // Disable game object after collection
        this.gameObject.SetActive(false);
    }

}
