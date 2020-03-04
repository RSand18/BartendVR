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
            Destroy(GameObject.FindWithTag("Orange"));
            Destroy(GameObject.FindWithTag("MartiniGlass_Unmixed"));
        }
    }
}
