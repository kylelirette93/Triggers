using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    public GameObject door;
    private int objectsInTrigger = 0;


    private void Start()
    {
        door.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        objectsInTrigger++;
        door.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        objectsInTrigger--;
        if (objectsInTrigger <= 0)
        {
            door.SetActive(true);
            objectsInTrigger--;
        } 
    }
}
