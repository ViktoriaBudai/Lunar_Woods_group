using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;



[System.Serializable]

public class InventoryItem
{
    public string itemName;
    public int quantity;
}


public class InventoryManager : MonoBehaviour
{
    //new scripts

    public HashSet<InventoryItem> inventory = new HashSet<InventoryItem>();

    public void AddItem(string itemName)
    {
        InventoryItem existingItem = inventory.FirstOrDefault(item => item.itemName == itemName);

        if (existingItem != null)
        {
            existingItem.quantity++;
        }
        else
        {
            InventoryItem newItem = new InventoryItem {  itemName = itemName, quantity = 1};
            inventory.Add(newItem);
        }
    }

    public bool HasItem(string itemName)
    {
        InventoryItem existingitem = inventory.FirstOrDefault (item => item.itemName == itemName);
        return existingitem != null && existingitem.quantity > 0; ;
    }
 
    //old script 
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;

    public void Awake()
    {
        Instance = this;
    }

    public void Add(Item item)
    {
        Items.Add(item);
    }

    public void Remove(Item item)
    {
        Items.Remove(item);
    }


    public void ListItems()
    {
        foreach (Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }


        foreach (var item in Items)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("Item/ItemName").GetComponent<Text>();
            var itemIcon = obj.transform.Find("Item/ItemIcon").GetComponent<Image>();

            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;
        }
    }
}
