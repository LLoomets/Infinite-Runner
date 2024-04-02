using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDestroy : MonoBehaviour
{
    public string parentName;

    void Start()
    {
        parentName = transform.name;
        StartCoroutine(DestroyClone());
    }

    IEnumerator DestroyClone()
    {
        yield return new WaitForSeconds(35);
        if (parentName == "Section(Clone)")
        {
            Destroy(gameObject);
        }
    }
}

