using UnityEngine;

public class PlayerController : MonoBehaviour
{
    static public PlayerController instance;

    private Transform currentDoor;
    private Vector2 doorPosition;

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

    public void EnterDoor(Transform door)
    {
        currentDoor = door;
        doorPosition = transform.position;
    }

    public void ExitDoor()
    {
        if (currentDoor != null)
        {
            transform.position = doorPosition;
            currentDoor = null;
        }
    }
}
