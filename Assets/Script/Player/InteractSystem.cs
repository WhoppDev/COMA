using UnityEngine;
using UnityEngine.InputSystem;

public class InteractSystem : MonoBehaviour
{
    public InputActionAsset inputActions;
    public float interactionDistance;

    public LayerMask interactableLayer;
    public AcenderLuz acenderLuz;

    public void Interact(InputAction.CallbackContext context)
    {
            if (context.started)
            {

                    Vector2 direction = transform.localScale.x > 0 ? Vector2.right : Vector2.left;
                    RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, interactionDistance, interactableLayer);

                    if (hit.collider != null)
                    {
                        Debug.Log("Hit: " + hit.collider.name);
                        acenderLuz = hit.collider.GetComponent<AcenderLuz>();
                        if (acenderLuz != null)
                        {
                            acenderLuz.IntectableButton(); // Chama o método sem passar parâmetros
                        }
                    }

                    Debug.DrawRay(transform.position, direction * interactionDistance, Color.red, 5f);

            }
    }


}
