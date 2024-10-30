using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    public GameObject door;

    
    private void OnTriggerEnter(Collider other)
    {
        door.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        door.SetActive(true);
    }
}
