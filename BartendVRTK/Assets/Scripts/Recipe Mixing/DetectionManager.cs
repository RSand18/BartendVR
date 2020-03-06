using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionManager : MonoBehaviour
{
    void OnTriggerEnter (Collider col)
    {
        if (col.tag == "MartiniGlass_Unmixed")
        {
            ValueManager.value = 1;
            Debug.Log("Value is 1");
            Destroy(GameObject.FindWithTag("Orange"));
            Destroy(GameObject.FindWithTag("MartiniGlass_Unmixed"));
        }

        if (col.tag == "BeerGlass_Unmixed")
        {
            ValueManager.value = 2;
            Debug.Log("Value is 2");
            Destroy(GameObject.FindWithTag("Lemon"));
            Destroy(GameObject.FindWithTag("BeerGlass_Unmixed"));
        }
    }
}
