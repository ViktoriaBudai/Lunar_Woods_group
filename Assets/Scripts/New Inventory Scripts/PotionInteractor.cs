using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionInteractor : MonoBehaviour, IInteractable
{
    public InventoryManager inventoryManager;

    public void Interact()
    {

        Debug.Log("interacting");
        inventoryManager.AddItem(gameObject.name);
        Destroy(gameObject, 0.1f);
    }

}
