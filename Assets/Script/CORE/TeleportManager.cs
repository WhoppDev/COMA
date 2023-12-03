using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportManager : MonoBehaviour
{
    public static TeleportManager Instance;

    // Informação sobre a porta usada para salvar entre cenas
    public string LastDoorUsed { get; private set; }

    void Awake()
    {
        // Garante que haja apenas uma instância desse gerenciador
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void TeleportPlayer(GameObject player, Vector3 newPosition, string newScene = null)
    {
        // Move o jogador para a posição especificada
        player.transform.position = newPosition;

        // Carrega a nova cena, se necessário
        if (!string.IsNullOrEmpty(newScene))
        {
            SceneManager.LoadScene(newScene);
        }
    }

    public void SetLastDoorUsed(string doorName)
    {
        LastDoorUsed = doorName;
    }
}
