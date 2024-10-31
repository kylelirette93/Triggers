using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnding : MonoBehaviour
{
    public GameObject endText;
    public ParticleSystem batParticles;

    private void Start()
    {
        endText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        endText.SetActive(true);
        batParticles.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        endText.SetActive(false);
    }
}