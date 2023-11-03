using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportController : MonoBehaviour
{
    private Transform currentDoor;
    private Vector2 doorPosition;

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
