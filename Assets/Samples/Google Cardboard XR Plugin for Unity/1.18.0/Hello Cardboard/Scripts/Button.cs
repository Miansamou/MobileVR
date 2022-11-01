using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject tp;
    public bool correto;
    public AudioSource audio;
    public AudioClip audioClip;

    public void OnPointerClick()
    {
        if (correto)
        {
            ActiveNextTp();
        }
        else
        {
            Scene scene = SceneManager.GetActiveScene(); 
            SceneManager.LoadScene(scene.name);
        }
        gameObject.tag = "none";
    }

    private void ActiveNextTp()
    {
        tp.SetActive(true);
        audio.PlayOneShot(audioClip);
    }
}
