using UnityEngine;

public class PlayerController : MonoBehaviour
{
    static public PlayerController instance;

    [Header("Player Status")]
    public int playerLife;
    public bool haveGun = false;


    [Header("Referencias")]
    public PlayerMoviment moviment;
    public Animator anim;
    public CombatController combat;
    public SpriteRenderer actionIcon;

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
