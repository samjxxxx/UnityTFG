﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInventory : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            //Debug.Log("press o");
            //int id = Random.Range(1,18);
            int id = Random.Range(1, 3);
            Knapsack.Instance.StoreItem(id);
        } 
    }
}
