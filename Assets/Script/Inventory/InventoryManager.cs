using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<GameObject> slots;
    private InventoryController invent�rio;

    void Start()
    {
        invent�rio = CORE.instance.inventarioController;
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

    // Remove um item espec�fico do invent�rio
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

    // Atualiza a UI do invent�rio
    public void UpdateInventoryUI()
    {
        foreach (GameObject slot in slots)
        {
            InventorySlot slotComponent = slot.GetComponent<InventorySlot>();
            slotComponent.UpdateSlotUI();
        }
    }
}

