using UnityEngine;
using UnityEngine.InputSystem;

public class Door : MonoBehaviour, IInteractable
{
    public string targetScene; // Cena para carregar (se necessário)
    public Vector3 targetPosition; // Posição para teletransportar o jogador
    public string doorName; // Nome dessa porta para rastreamento

    public void Interact()
    {
            TeleportManager.Instance.SetLastDoorUsed(doorName);
            TeleportManager.Instance.TeleportPlayer(CORE.instance.player, targetPosition, targetScene);
    }
}
