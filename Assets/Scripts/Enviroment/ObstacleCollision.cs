using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    
    public GameObject thePlayer;
    public GameObject characterModel;
    public GameObject levelControl;

    // kutsutakse välja kui player puutub kokku obstacle-ga
    void OnTriggerEnter(Collider other)
    {
        // disable collider, et ennetada mitmeid collision-eid
        this.gameObject.GetComponent<BoxCollider>().enabled = false;

        // lõpetab playeri liikumise
        thePlayer.GetComponent<PlayerMove>().enabled = false;

        characterModel.GetComponent<Animator>().Play("Stumble Backwards");

        // lõpetab distance lugemise
        levelControl.GetComponent<LevelDistance>().enabled = false;

        // käivitab jooksu lõppemise järel EndRunSequence-i
        levelControl.GetComponent<EndRunSequence>().enabled = true;
    }

}
