using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportController : MonoBehaviour
{
    public GameObject player;
    public GameObject location;
    public GameObject charada;
    public AudioSource audio;
    public AudioClip audioClip;

    public void OnPointerClick()
    {
        TeleportPlayer();
        gameObject.tag = "none";
    }

    private void TeleportPlayer()
    {
        player.gameObject.transform.position = location.gameObject.transform.position;
        charada.SetActive(true);
        audio.PlayOneShot(audioClip);
    }
}
