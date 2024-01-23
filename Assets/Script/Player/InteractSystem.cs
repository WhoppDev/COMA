using UnityEngine;
using UnityEngine.InputSystem;

public class InteractSystem : MonoBehaviour
{
    public InputActionAsset inputActions;
    public float interactionDistance;

    public LayerMask interactableLayer;
    public Interruptor acenderLuz;

    public GameObject inventory;
    public bool openInventory = false;

    public void Interact(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Vector2 direction = transform.localScale.x > 0 ? Vector2.right : Vector2.left;
            RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, interactionDistance, interactableLayer);

            if (hit.collider != null)
            {
                Debug.Log("Hit: " + hit.collider.name);
                IInteractable interactableObj = hit.collider.GetComponent<IInteractable>();
                if (interactableObj != null)
                {
                    interactableObj.Interact();
                }
            }

            Debug.DrawRay(transform.position, direction * interactionDistance, Color.red, 5f);
        }
    }

    public void OpenInventory(InputAction.CallbackContext context)
    {
        openInventory = !openInventory;

        if (context.started)
        {
            if (openInventory)
            {
            inventory.SetActive(true);
            }
            else
            {
            inventory.SetActive(false);
            }
        }
    }
}
