using UnityEngine;

public class PlayerController : MonoBehaviour
{
    static public PlayerController instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = GetComponent<PlayerController>();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
