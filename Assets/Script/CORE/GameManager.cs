using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float playerMoviment;

    [Header("Player Life")]
    [SerializeField] private float maxPlayerLife = 5;
    [SerializeField] private float currentPlayerLife;

    [Header("Player Tired")]
    [SerializeField] private float maxPlayerTired = 10;
    [SerializeField] private float currentPlayerTired;
    public bool isTired = false;
    

    // Start is called before the first frame update
    void Start()
    {
        currentPlayerLife = maxPlayerLife;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentPlayerLife <= 0)
        {
            CORE.instance.animController.anim.SetBool("isDead", true);
        }

        PlayerTired();
    }

    public void TakeDamage()
    {
        currentPlayerLife--;
    }

    private void PlayerTired()
    {
        float tiredColdown = Time.deltaTime;


        if(CORE.instance.playerMoviment.isRunning == true)
        {
            currentPlayerTired -= tiredColdown;
        }

        if (CORE.instance.playerMoviment.isRunning == false)
        {
            currentPlayerTired += tiredColdown;
        }

        currentPlayerTired = Mathf.Clamp(currentPlayerTired, 0, maxPlayerTired);

        if (currentPlayerTired <= 0)
        {
            isTired = true;
            CORE.instance.animController.anim.SetBool("isTired", isTired);
        }

        if (currentPlayerTired >= (maxPlayerTired/2))
        {
            isTired = false;
            CORE.instance.animController.anim.SetBool("isTired", isTired);
        }
    }
}
