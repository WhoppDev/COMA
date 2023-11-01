using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAppear : MonoBehaviour
{
    [SerializeField] private AudioClip _hitSound;

    [SerializeField] private GameObject hand;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioManager.PlaySound(_hitSound);
        hand.SetActive(true);
    }
}
