
using UnityEngine;


// item nằm trên mặt đất 
public class Item : MonoBehaviour
{
    [ItemCodeDecription]
    [SerializeField]
    private int _itemCode;

    private SpriteRenderer spriteRenderer;

    public int ItemCode { get { return _itemCode; } set { _itemCode = value; } }

    private void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Start()
    {
        if (ItemCode != 0)
        {
            Init(ItemCode);
        }
    }

    public void Init(int itemCodeParam)
    {
        if(itemCodeParam != 0)
        {
            ItemCode = itemCodeParam;

            ItemDetails itemDetails = InventoryManager.Instance.GetItemDetails(ItemCode);

            spriteRenderer.sprite = itemDetails.itemSprite;

            // Nếu itemType của itemDetails là Reapable_scenary thì mới làm 
            if(itemDetails.itemType == ItemType.Reapable_scenary)
            {
                gameObject.AddComponent<ItemNudge>();
            }
        }
    }
}
