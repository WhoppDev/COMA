using UnityEngine;

public class PlayerController : MonoBehaviour
{
    static public PlayerController instance;

    [Header("Player Status")]
    public int playerLife;
    public bool haveGun = false;


    [Header("Referencias")]
    public PlayerMoviment moviment;
    public AnimationController anim;
    public CombatController combat;

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
