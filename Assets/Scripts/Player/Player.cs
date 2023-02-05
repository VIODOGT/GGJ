using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject InteractImg;
    public GameObject Border;
    public AudioSource audioSource;
    public AudioClip StopShiftingSound;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
       /* if (Input.GetKey(KeyCode.W))
        {
            if (audioSource.isPlaying == false)
            {
            audioSource.Play(0);
            }
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            audioSource.Stop();
            audioSource.PlayOneShot(StopShiftingSound);

        }
        //IEnumerator LoopShiftingSound*/
    }
}
