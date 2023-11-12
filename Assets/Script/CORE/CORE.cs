using UnityEngine;

public class CORE : MonoBehaviour
{
    static public CORE instance;

    public GameManager gameManager;
    public SceneController sceneController;
    public TeleportController teleportController;
    public PlayerMoviment playerMoviment;

    public GameObject player;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = GetComponent<CORE>();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
