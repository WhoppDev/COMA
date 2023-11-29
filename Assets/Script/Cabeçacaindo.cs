using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabeçacaindo : MonoBehaviour
{
    [SerializeField] private AudioClip _hitSound;
    public Animator anim;
    public bool cabeçacaiu = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(cabeçacaiu==false)
        {
            anim.SetTrigger("cabeçacaindo");
            AudioManager.PlaySound(_hitSound);
            cabeçacaiu = true;
        }
        
    }
}
