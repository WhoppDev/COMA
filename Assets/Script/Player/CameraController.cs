using Unity.Cinemachine;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private CinemachineCamera vcam;

    [SerializeField] private GameObject player;

    private void OnEnable()
    {
        player = FindFirstObjectByType<PlayerController>().gameObject;

        vcam.Follow = player.transform;
    }

}
