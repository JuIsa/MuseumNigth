using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnCtrl : MonoBehaviour
{
    public GameObject house;
    public GameObject flat;
    void Start()
    {
        
    }

    public void onHouseClick()
    {
        house.SetActive(true);
        flat.SetActive(false);
    }

    public void onFlatClick()
    {
        house.SetActive(false);
        flat.SetActive(true);
    }
}
