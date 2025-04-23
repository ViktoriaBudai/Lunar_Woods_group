using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

using UnityEngine;

public class ItemPickup_5 : MonoBehaviour
{
    public GameObject pickupEffect; // Effect to play when item is picked up
    public Sprite itemSprite; // Sprite of the item to display in the inventory

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup();           
        }
    }

    void Pickup()
    {
        // Play pickup effect
        Instantiate(pickupEffect, transform.position, transform.rotation);

        // Hide the item
        gameObject.SetActive(false);

        // Show picture on screen (you can implement this part separately)
        UpdateInventoryDisplay();
    }

    void UpdateInventoryDisplay()
    {
        // Find the InventoryDisplay script on the UI canvas
        InventoryDisplay_5 inventoryDisplay = FindObjectOfType<InventoryDisplay_5>();

        if (inventoryDisplay != null)
        {
            // Update the displayed item sprite
            inventoryDisplay.UpdateItemSprite(itemSprite);
        }
    }
}

