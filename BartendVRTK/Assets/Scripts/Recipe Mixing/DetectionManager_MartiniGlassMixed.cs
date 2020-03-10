using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionManager_MartiniGlassMixed : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Lemon")
        {
            ValueManager.value = 3;
            Debug.Log("Value is 3");
            Destroy(GameObject.FindWithTag("Lemon"));
            Destroy(GameObject.FindWithTag("MartiniGlass_Mixed"));
        }
    }

}