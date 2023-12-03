using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportManager : MonoBehaviour
{
    public static TeleportManager Instance;

    // Informa��o sobre a porta usada para salvar entre cenas
    public string LastDoorUsed { get; private set; }

    void Awake()
    {
        // Garante que haja apenas uma inst�ncia desse gerenciador
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
        // Move o jogador para a posi��o especificada
        player.transform.position = newPosition;

        // Carrega a nova cena, se necess�rio
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
