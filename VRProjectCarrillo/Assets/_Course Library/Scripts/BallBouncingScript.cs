using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBouncingScript : MonoBehaviour
{
    private Rigidbody rb;
    private AudioSource audioSource;

    [SerializeField] private AudioClip bounceSound;
    private float volumeSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }


    void OnCollisionEnter(Collision collision)
    {
       
        volumeSound = rb.velocity.magnitude;
        Debug.Log(volumeSound); 

        audioSource.PlayOneShot(bounceSound, volumeSound);
    }
}
