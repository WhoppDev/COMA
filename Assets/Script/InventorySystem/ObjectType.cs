using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectType : MonoBehaviour, IInteractable
{
    public ItensDATA objectType;
    public InventoryController inventory;

    public void Interact()
    {
        inventory = FindObjectOfType<InventoryController>();
        if (inventory != null)
        {
            inventory.AddItemToInventory(objectType);
            Destroy(gameObject); // Destruir o objeto depois de adicionado ao inventário
        }
    }
}

