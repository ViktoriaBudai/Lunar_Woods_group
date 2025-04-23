using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UI_InteracteImage : MonoBehaviour
{
    public InventoryManager inventoryManager;

    [Header("Interactable Images")]
    [SerializeField] private RawImage[] interactableImages;
    [SerializeField] private string[] itemNames;

    // Update is called once per frame
    void Update()
    {
      for (int i = 0; i < interactableImages.Length; i++)
        {
            UpdateInventoryImage(interactableImages[i], itemNames[i]);

        }
    }

    private void UpdateInventoryImage(RawImage InventoryImage, string itemName)
    {
        bool hasItem = inventoryManager.HasItem(itemName);
        InventoryImage.enabled = hasItem;
    }
}