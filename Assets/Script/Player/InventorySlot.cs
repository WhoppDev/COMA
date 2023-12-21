using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public ItensDATA itemData;

    [SerializeField] GameObject useMenu, inspectMenu, destroyMenu;

    private void Start()
    {
        useMenu.SetActive(false);
        inspectMenu.SetActive(false);
        destroyMenu.SetActive(false);

        if(itemData.canUse == true)
        {
            useMenu.SetActive(true);
        }

        if (itemData.canInspect == true)
        {
            inspectMenu.SetActive(true);
        }

        if (itemData.canDestroy == true)
        {
            destroyMenu.SetActive(true);
        }
    }
    public void SetItemData(ItensDATA data)
    {
        itemData = data;
        
    }

    public void DestroyItem()
    {
        Destroy(transform.parent.gameObject);
    }




}



