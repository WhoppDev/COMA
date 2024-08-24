using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<GameObject> slots;
    private InventoryController inventário;

    void Start()
    {
        inventário = CORE.instance.inventarioController;
    }

    // Adiciona um item ao primeiro slot vazio encontrado
    public void AddItemToInventory(ItensDATA itemData)
    {
        foreach (GameObject slot in slots)
        {
            InventorySlot slotComponent = slot.GetComponent<InventorySlot>();
            if (slotComponent.itemData == itemData)
            {
                slotComponent.UpdateQuantity(itemData.quantity + 1);
                return;
            }
        }

        foreach (GameObject slot in slots)
        {
            InventorySlot slotComponent = slot.GetComponent<InventorySlot>();
            if (slotComponent.IsEmpty)
            {
                itemData.quantity = 1; 
                slotComponent.AssignItem(itemData);
                break;
            }
        }

        UpdateInventoryUI();

    }

    // Remove um item específico do inventário
    public void RemoveItemFromInventory(ItensDATA itemData)
    {
        foreach (GameObject slot in slots)
        {
            InventorySlot slotComponent = slot.GetComponent<InventorySlot>();
            if (slotComponent.itemData == itemData)
            {
                slotComponent.ClearSlot();
                break;
            }
        }
    }

    // Atualiza a UI do inventário
    public void UpdateInventoryUI()
    {
        foreach (GameObject slot in slots)
        {
            InventorySlot slotComponent = slot.GetComponent<InventorySlot>();
            slotComponent.UpdateSlotUI();
        }
    }
}

