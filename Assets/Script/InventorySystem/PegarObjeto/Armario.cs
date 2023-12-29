using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Armario : MonoBehaviour, IInteractable
{
    public ItensDATA[] itens;
    public Image[] slotImage;
    public int[] slotAmount;

    public void Interact()
    {
        Debug.Log("Abriu o Armário");
        for (int i = 0; i < itens.Length; i++)
        {
            if (i < slotImage.Length)
            {
                slotImage[i].sprite = itens[i].itemIcon;
            }
        }
    }
}
