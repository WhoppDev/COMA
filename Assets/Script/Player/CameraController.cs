using Cinemachine;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera vcam;

    [SerializeField] private GameObject player;

    private void OnEnable()
    {
        player = FindObjectOfType<PlayerController>().gameObject;

        vcam.Follow = player.transform;
    }

}
