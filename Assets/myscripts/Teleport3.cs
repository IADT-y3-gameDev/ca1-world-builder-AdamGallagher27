using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport3 : MonoBehaviour
{
    public Transform reciever;
    
    void OnTriggerEnter(Collider other)
    {
        other.transform.position = reciever.position;
    }
}
