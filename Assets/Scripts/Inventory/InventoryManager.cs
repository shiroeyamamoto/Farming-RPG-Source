using System;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : SingletonMonobehavior<InventoryManager>
{
    [SerializeField] private Dictionary<int, ItemDetails> itemDetailsDictionary;

    [SerializeField] SO_ItemList itemList = null;

    protected void Awake()
    {
        base.Awake();

        // Create item details dictionary
        CreateItemDetailsDictionary();
    }

    private void Start()
    {
        //Debug.Log(itemDetailsDictionary);
    }

    /// <summary>
    /// Populates the itemDetailsDictionary from the scriptable oject items list
    /// </summary>
    private void CreateItemDetailsDictionary()
    {
        itemDetailsDictionary = new Dictionary<int, ItemDetails>();

        foreach (ItemDetails itemDetails in itemList.itemDetails)
        {
            itemDetailsDictionary.Add(itemDetails.itemCode, itemDetails);
        }
    }
    /// <summary>
    /// Returns the itemDetails (from the SO_ItemList) for itemCode, or null if the itemCode doesn't exits
    /// </summary>
    public ItemDetails GetItemDetails(int itemCode)
    {
        ItemDetails itemDetails;

        if (itemDetailsDictionary.TryGetValue(itemCode, out itemDetails))
        {
            return itemDetails;
        }
        else
        {
            return null;
        }
    }
}
