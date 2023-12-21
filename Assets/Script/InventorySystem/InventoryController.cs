using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class InventoryController : MonoBehaviour
{
    public ItensDATA[] slots;
    public Image[] slotImage;
    public int[] slotAmount;

    private bool isTaking = false;
    private RaycastHit2D currentHit;

    public void SetCurrentHit(RaycastHit2D hit)
    {
        currentHit = hit;
    }

    public void AddItemToInventory(ItensDATA item)
    {
        Debug.Log("Item recebido");
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i] == null || slots[i].name == item.name)
            {
                slots[i] = item;
                slotAmount[i]++;
                slotImage[i].sprite = item.itemIcon;
                break;
            }
        }
        Debug.Log("Cadastrado");
    }
}




