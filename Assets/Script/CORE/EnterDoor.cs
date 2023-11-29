using UnityEngine;

public class EnterDoor : MonoBehaviour
{
    [SerializeField] private string doorName;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            CORE.instance.teleportController.EnterDoor(doorName);
        }
    }
}
