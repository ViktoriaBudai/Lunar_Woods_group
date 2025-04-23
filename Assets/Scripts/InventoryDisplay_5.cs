using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class InventoryDisplay_5 : MonoBehaviour
{
    public Image itemImage; // Reference to the Image component displaying the item sprite

    public void UpdateItemSprite(Sprite newSprite)
    {
        // Update the item sprite on the inventory display
        itemImage.sprite = newSprite;
        itemImage.enabled = true; // Show the item image

        Debug.Log("Item sprite set: " + newSprite.name); // Debug statement
    }
}

