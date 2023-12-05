using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerAudio : MonoBehaviour
{
    public AudioSource MusicPlayer;
    public GameObject trigger;

    private void OnTriggerEnter(Collider other)
    {
        MusicPlayer.Play();

        trigger.SetActive(false);

        Debug.Log("run");
    }
}
