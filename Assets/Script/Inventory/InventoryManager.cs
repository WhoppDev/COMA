using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<GameObject> slots;

    void Start()
    {
        InitializeSlots();
    }

    private void InitializeSlots()
    {
        foreach (GameObject slot in slots)
        {
            InventorySlot slotComponent = slot.GetComponent<InventorySlot>();
            if (slotComponent != null)
            {
                slotComponent.ClearSlot();
            }
        }
    }

    // Adiciona um item ao primeiro slot vazio encontrado
    public void AddItemToInventory(ItensDATA itemData)
    {
        Debug.Log("chamou a função");
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
                break; // Interrompe o loop assim que o item for removido
            }
        }
    }
}

