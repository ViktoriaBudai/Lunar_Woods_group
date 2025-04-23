using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public GameObject Inventory;
    public bool inventoryIsClosed;
    

    void Start()
    {
        inventoryIsClosed = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("i"))
        {
            if (inventoryIsClosed == true) 
            { 
                Inventory.SetActive(true);
                inventoryIsClosed = false;

            }
            else
            {
                Inventory.SetActive(false);
                inventoryIsClosed = true;
            }
        }

        

    }
}
