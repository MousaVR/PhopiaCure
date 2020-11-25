using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSensor : MonoBehaviour
{
    [SerializeField] Animator doorSensor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            doorSensor.SetBool("OpenTheDoor", true);
    }

}
