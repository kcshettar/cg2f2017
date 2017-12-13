using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSound : MonoBehaviour {

    AudioSource audioSource = null;
    AudioClip impactClip = null;

    // Use this for initialization
    void Start()
    {
        // Add an AudioSource component and set up some defaults
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.spatialize = true;
        audioSource.spatialBlend = 1.0f;
        audioSource.dopplerLevel = 0.0f;
        audioSource.rolloffMode = AudioRolloffMode.Logarithmic;
        audioSource.maxDistance = 20f;

        // Load the Cube sounds from the Resources folder
        impactClip = Resources.Load<AudioClip>("Cardboard_audio_1");
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Occurs when this object starts colliding with another object
    void OnCollisionEnter(Collision collision)
    {
        // Play an impact sound 
        audioSource.clip = impactClip;
        audioSource.Play();
    }
}
