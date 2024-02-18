using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;

    public GameObject warning;

    private void Update()
    {
        if(isFull[0] && isFull[1] && isFull[2])
        {
            warning.SetActive(true);
        } else if(warning.activeInHierarchy)
        {
            warning.SetActive(false);
        }
    }
}
