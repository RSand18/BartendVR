using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionManagerMartiniGlass : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Orange")
        {
            ValueManager.value = 1;
            Debug.Log("Value is 1");
            Destroy(GameObject.FindWithTag("Orange"));
            Destroy(GameObject.FindWithTag("MartiniGlass_Unmixed"));
        }
    }
}
