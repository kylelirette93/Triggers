using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pickup : MonoBehaviour
{
    public GameObject clickText;
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

    private void Update()
    {
        // If the player clicks the mouse button, pickup the object.
        if (playerInTrigger && Input.GetMouseButton(0))
        {
            transform.SetParent(GameObject.FindGameObjectWithTag("Player").transform);
        }
        else
        {
            transform.SetParent(null);
        }
    }


}
