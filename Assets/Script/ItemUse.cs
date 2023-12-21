using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUse : MonoBehaviour
{
    public ItensDATA slot;
    public GameObject actionMenuPrefab;
    public GameObject actionMenuInstance;
    public void TakeItem(int index)
    {
        if(CORE.instance.inventory.slots[index] != null)
        {
            slot = CORE.instance.inventory.slots[index];
            CreateItemInstance(slot);
        }
    }

    private void CreateItemInstance(ItensDATA itemData)
    {
        if (actionMenuInstance != null)
        {
            Destroy(actionMenuInstance);
        }

        actionMenuInstance = Instantiate(actionMenuPrefab, Vector3.zero, Quaternion.identity, this.transform);

        actionMenuInstance.transform.localPosition = Vector3.zero;
        actionMenuInstance.transform.localScale = Vector3.one;


        InventorySlot itemBehaviour = actionMenuInstance.GetComponent<InventorySlot>();
        if (itemBehaviour != null)
        {
            itemBehaviour.SetItemData(itemData);
        }
    }

}
