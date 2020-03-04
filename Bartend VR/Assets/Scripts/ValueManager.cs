using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueManager : MonoBehaviour
{
    public static int value = 0;
    public GameObject MartiniGlass_Unmixed, Orange, MartiniGlass_Mixed;
    // Start is called before the first frame update
    void Start()
    {
        MartiniGlass_Unmixed.SetActive(true);
        Orange.SetActive(true);
        MartiniGlass_Mixed.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (value == 1)
        {
            MartiniGlass_Unmixed.SetActive(false);
            Orange.SetActive(false);
            MartiniGlass_Mixed.SetActive(true);
        }
    }
}
