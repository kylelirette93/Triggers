using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pickup : MonoBehaviour
{
    public GameObject clickText;
    float zOffset = 2f;
    float groundLevel = 1.5f;
    float pickupThreshold = 0.2f;
    bool playerInTrigger = false;

    




    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Text is enabled.");
        if (other.gameObject.CompareTag("Player"))
        {
            playerInTrigger = true;
            clickText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Text is enabled.");
        if (other.gameObject.CompareTag("Player"))
        {
            clickText.SetActive(false);
        }
    }

    private void Update()
    {
        // If the player clicks the mouse button, pickup the object.
        if (playerInTrigger && Input.GetMouseButton(0))
        {
            transform.localPosition = new Vector3(0, 0, zOffset);
            transform.SetParent(GameObject.FindGameObjectWithTag("Player").transform);
        }
        else
        {
            transform.SetParent(null);
        }
    }
}