using UnityEngine;

[System.Serializable]
public class ItemDetails
{
    public int itemCode;
    public ItemType itemType;
    public string itemDescription;
    public Sprite itemSprite;
    public string itemLongDescription;
    // sử dụng grid
    public short itemUseGridRadius;
    // Sử dụng khoảng cách 
    public float itemUseRadius;
    public bool isStartingItem;
    public bool canBePickUp;
    public bool canBeDropped;
    public bool canBeEaten;
    public bool canBeCarried;
}
