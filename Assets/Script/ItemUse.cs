using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUse : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Destroy(this);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
