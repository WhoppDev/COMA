using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarScena : MonoBehaviour
{
    [SerializeField] private GameObject normalScene;
    [SerializeField] private GameObject terrifyScene;
    [SerializeField] private GameObject light;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        normalScene.SetActive(false);
        terrifyScene.SetActive(true);
        light.SetActive(true);
    }
}
