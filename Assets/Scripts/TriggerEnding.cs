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

    private void OnTriggerStay(Collider other)
    {
        endText.SetActive(true);
    }
}
