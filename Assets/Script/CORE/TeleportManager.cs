using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportManager : MonoBehaviour
{
    public static string lastDoorUsed = "";

    public Transform playerTransform;

    private void Start()
    {
        playerTransform = FindAnyObjectByType<PlayerController>().transform;
        PositionPlayer();

    }

    public void EnterDoor(string doorName)
    {
        lastDoorUsed = doorName;
        SceneManager.LoadScene(doorName);
    }

    public void PositionPlayer()
    {
        if (lastDoorUsed != "")
        {
            GameObject door = GameObject.Find(lastDoorUsed);
            if (door != null)
            { 
                playerTransform.position = door.transform.position;
            }
        }
    }

    public void ResetLastDoorUsed()
    {
        lastDoorUsed = "";
    }
}
