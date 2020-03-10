using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionManagerBeerGlass : MonoBehaviour
{
    void OnTriggerEnter (Collider col)
    {
        if (col.tag == "Lemon")
        {
            ValueManager.value = 2;
            Debug.Log("Value is 2");
            Destroy(GameObject.FindWithTag("Lemon"));
            Destroy(GameObject.FindWithTag("BeerGlass_Unmixed"));
        }
    }
}
