using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeGun : MonoBehaviour, IInteractable
{
    public SpriteRenderer sprite;

    public Sprite newSprite;

    public Collider2D ligarCollider;

    public AudioClip pegarArma;
    [SerializeField] private AudioSource _audioSource;

    public void Interact()
    {
        PlayerController.instance.anim.SetTrigger("Take");
        PlayerController.instance.anim.SetBool("isTaking", true);

        sprite.sprite = newSprite;
        PlayerController.instance.haveGun = true;

        ligarCollider.enabled = true;
        StartCoroutine(PegartArma());
        AudioManager.PlaySound(pegarArma);
        this.gameObject.SetActive(false);
    }

    public IEnumerator PegartArma()
    {
        yield return new WaitWhile(() => _audioSource.isPlaying);
        yield return new WaitForSeconds(0.5f);
        PlayerController.instance.anim.SetBool("isTaking", false);
    }



}
