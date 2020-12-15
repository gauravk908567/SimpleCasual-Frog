using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag=="Car")
        {
            target.gameObject.transform.parent = transform;

            target.gameObject.SetActive(false);

        }
    }
}
