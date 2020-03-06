using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueManager : MonoBehaviour
{
    public static int value = 0;
    public GameObject MartiniGlass_Unmixed, MartiniGlass_Mixed, BeerGlass_Unmixed, BeerGlass_Mixed, Orange, Lemon;
    // Start is called before the first frame update
    void Start()
    {
        MartiniGlass_Unmixed.SetActive(true);
        BeerGlass_Unmixed.SetActive(true);
        MartiniGlass_Mixed.SetActive(false);
        BeerGlass_Mixed.SetActive(false);
        Orange.SetActive(true);
        Lemon.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (value == 1)
        {
            Debug.Log("Value has been increased");
            Debug.Log("Orange Hidden");
            MartiniGlass_Mixed.SetActive(true);
            Debug.Log("Orange Martini Glass active");
        }

        if (value == 2)
        {
            BeerGlass_Mixed.SetActive(true);
            Debug.Log("Yellow Beer Glass active");
        }
    }
}
