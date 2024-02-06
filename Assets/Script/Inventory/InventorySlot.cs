using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventorySlot : MonoBehaviour
{
    public ItensDATA itemData;
    public Image iconImage;
    public int quantity;
    public TMP_Text quantityText;

    private void Awake()
    {
        iconImage = GetComponentInChildren<Image>();
        quantityText = GetComponentInChildren<TMP_Text>();
    }

    public bool IsEmpty => itemData == null;

    public void AssignItem(ItensDATA newItemData)
    {
        itemData = newItemData;
        UpdateSlotUI(); 
    }

    public void UpdateQuantity(int newQuantity)
    {
        if (itemData != null)
        {
            itemData.quantity = newQuantity;
            quantityText.text = newQuantity > 1 ? newQuantity.ToString() : "";
            quantity = newQuantity > 1 ? newQuantity : 0;
            UpdateSlotUI();
        }
    }

    public void ClearSlot()
    {
        itemData = null;
        UpdateSlotUI();
    }

    private void UpdateSlotUI()
    {
        if (itemData != null)
        {
            iconImage.sprite = itemData.itemIcon;
            quantityText.text = itemData.quantity > 1 ? itemData.quantity.ToString() : "";
            quantity = itemData.quantity > 1 ? itemData.quantity : 0;
            iconImage.gameObject.SetActive(true);
            quantityText.gameObject.SetActive(true);
        }
        else
        {
            iconImage.gameObject.SetActive(false);
            quantityText.gameObject.SetActive(false);
        }
    }
}

