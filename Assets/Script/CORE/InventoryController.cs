using UnityEngine;
using UnityEngine.InputSystem;

public class InventoryController : MonoBehaviour
{
    public GameObject inventoryPanel;

    private bool inventoryActive = false;
    [SerializeField] private InventoryManager inventoryManager;

    public Inventario inventario;

    private void Start()
    {
        inventario = new Inventario();
        inventario.Load();
    }


    public void OnInventory(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            inventoryActive = !inventoryActive;
            inventoryManager.UpdateInventoryUI();
            inventoryPanel.SetActive(inventoryActive);
        }
    }


}
