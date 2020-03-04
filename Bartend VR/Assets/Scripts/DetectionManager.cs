using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionManager : MonoBehaviour
{
    void OnTriggerEnter (Collider col)
    {
        if (col.tag == "Orange")
        {
            ValueManager.value += 1;
        }
    }
}
