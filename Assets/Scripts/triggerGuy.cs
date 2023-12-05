using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerGuy : MonoBehaviour
{
    public GameObject trigger;

    private void OnTriggerEnter(Collider other)
    {
        trigger.SetActive(false);

        Debug.Log("boo");
    }
}
