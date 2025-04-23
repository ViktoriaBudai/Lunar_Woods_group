using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class ItemPickup : MonoBehaviour
{
    
    public Item Item;
    public Transform ItemContent;
    public GameObject InventoryItem;

    public GameObject pickupEffect; // Effect to play when item is picked up
    public AudioClip pickupSound; // Sound to play when item is picked up

    void Pickup()
    {
        GameObject effectInstance = Instantiate(pickupEffect, transform.position, transform.rotation); // Instantiate pickup effect
       
        if (pickupSound != null )  // Play pickup sound effect
        {
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);
        }

        InventoryManager.Instance.Add(Item);  // Add item to inventory
        Destroy(gameObject);
        
        Destroy(effectInstance, 3f); // Destroy the visual effect after 3 seconds
    }

   
    private void OnTriggerEnter()
    {
        Pickup();
        
    }

}
