using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeGun : MonoBehaviour, IInteractable
{
    public SpriteRenderer sprite;

    public Sprite newSprite;

    public Collider2D ligarCollider;

    public void Interact()
    {
        PlayerController.instance.anim.SetTrigger("Take");
        sprite.sprite = newSprite;
        PlayerController.instance.haveGun = true;

        ligarCollider.enabled = true;
        this.gameObject.SetActive(false);
    }



}
