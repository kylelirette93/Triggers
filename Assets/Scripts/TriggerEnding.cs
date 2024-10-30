using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnding : MonoBehaviour
{
    public GameObject endText;

    private void Start()
    {
        endText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        endText.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        endText.SetActive(false);
    }
}
