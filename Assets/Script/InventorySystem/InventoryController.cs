using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class InventoryController : MonoBehaviour, IInteractable
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

    public void Interact()
    {
        if (!isTaking && currentHit.collider != null && currentHit.collider.tag == "Objects")
        {
            isTaking = true;
            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i] == null || slots[i].name == currentHit.transform.GetComponent<ObjectType>().objectType.name)
                {
                    slots[i] = currentHit.transform.GetComponent<ObjectType>().objectType;
                    slotAmount[i]++;
                    slotImage[i].sprite = slots[i].itemIcon;

                    Destroy(currentHit.transform.gameObject);
                    break;
                }
            }
            isTaking = false; // Reset the flag after interaction
        }
    }
}




