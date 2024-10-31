using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWalkway : MonoBehaviour
{
    public GameObject walkway;
    public GameObject wireFrame;

    private void Start()
    {
        walkway.SetActive(false);
        wireFrame.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        walkway.SetActive(true);
        wireFrame.SetActive(false);
    }
}
