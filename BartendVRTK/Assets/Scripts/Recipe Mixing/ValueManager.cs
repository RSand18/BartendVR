using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueManager : MonoBehaviour
{
    public static int value = 0;
    public GameObject MartiniGlass_Unmixed, MartiniGlass_Mixed, MartiniGlass_Mixed_Lemon, BeerGlass_Unmixed, BeerGlass_Mixed, Orange, Lemon;
    // Start is called before the first frame update
    void Start()
    {
        MartiniGlass_Unmixed.SetActive(true);
        BeerGlass_Unmixed.SetActive(true);
        MartiniGlass_Mixed_Lemon.SetActive(false);
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
            MartiniGlass_Mixed.SetActive(true);
        }

        if (value == 2)
        {
            BeerGlass_Mixed.SetActive(true);
        }

        if (value == 3)
        {
            MartiniGlass_Mixed.SetActive(false);
            Debug.Log("Reached");
            MartiniGlass_Mixed_Lemon.SetActive(true);
        }
    }
}
