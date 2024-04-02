using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 6;
    public float leftRightSpeed = 4;
    static public bool canMove = false;
    public bool isJumping = false;
    public bool comingDown = false;
    public GameObject playerObject;
 

    void Update()
    {
        // Player liigub lõpmtault edasi
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed,  Space.World);

        // Player liigub vasakule-paremale
        if (canMove == true)
        {
            if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                if(this.gameObject.transform.position.x > LevelBoundary.leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                }
            }

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                if(this.gameObject.transform.position.x < LevelBoundary.rightSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
                }
            }
            // Player hüppab
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space))
            {
                if (isJumping == false)
                {
                    isJumping = true;
                    playerObject.GetComponent<Animator>().Play("Running Forward Flip");
                    StartCoroutine(JumpSequence());
                }
            }
        }

        // Hüppe liikumised
        if (isJumping == true)
        {
            if (comingDown == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 3.5f, Space.World);
            }
            if (comingDown == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -3.5f, Space.World);
            }
        }

    }

    // Hüppe sequence
    IEnumerator JumpSequence() 
    {
        float initialHeight = transform.position.y;

        yield return new WaitForSeconds(0.45f);
        comingDown = true;

        yield return new WaitForSeconds(0.45f);
        isJumping = false;

        comingDown = false;
        playerObject.GetComponent<Animator>().Play("Standard Run");
        // Algus positsiooni
        transform.position = new Vector3(transform.position.x, initialHeight, transform.position.z);
    }
}
