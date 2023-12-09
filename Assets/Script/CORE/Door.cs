using UnityEngine;
using UnityEngine.InputSystem;

public class Door : MonoBehaviour, IInteractable
{
    public string targetScene; // Cena para carregar (se necessário)
    public Vector3 targetPosition; // Posição para teletransportar o jogador
    public string doorName; // Nome dessa porta para rastreamento
    public Animator fadeAnim;

    public Sprite action;

    public Keys requiredKey;

    public void Interact()
    {
        if(requiredKey == null || requiredKey.takeKey)
        {
            fadeAnim.SetTrigger("FadeOut");
        }
    }

    public void OnFadeComplete()
    {
        TeleportManager.Instance.SetLastDoorUsed(doorName);
        TeleportManager.Instance.TeleportPlayer(CORE.instance.player, targetPosition, targetScene);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController.instance.actionIcon.sprite = action;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController.instance.actionIcon.sprite = null;
        }
    }
}
