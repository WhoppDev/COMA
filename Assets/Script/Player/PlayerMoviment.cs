using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoviment : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator anim;
    [SerializeField] private float playerSpeed = 5f;
    [SerializeField] private float runningSpeed = 10f;

    public bool isRunning = false;
    private bool isShiftPressed = false;


    private Vector2 direction;

    private void Update()
    {
        WalkAnimation();
        anim.SetBool("isRunning", isRunning && direction.magnitude > 0);
    }

    void FixedUpdate()
    {
        if(PlayerController.instance.combat.isAttacking || CORE.instance.gameManager.isTired)
        {
            return;
        }


        if(isRunning && !PlayerController.instance.combat.isAttacking)
        {
            rb.linearVelocity = new Vector2(direction.x * runningSpeed, rb.linearVelocity.y);
        } 
        else if(!isRunning && !PlayerController.instance.combat.isAttacking)
        {
            rb.linearVelocity = new Vector2(direction.x * playerSpeed, rb.linearVelocity.y);
        }

        if (direction.x < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (direction.x > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

    }

    private void WalkAnimation()
    {
        if(direction.magnitude > 0)
        {
            anim.SetBool("isWalk", true);
        }
        else
        {
            anim.SetBool("isWalk", false);
        }
    }

    public void Moviment(InputAction.CallbackContext value)
    {
        direction = value.ReadValue<Vector2>();
        CORE.instance.gameManager.playerMoviment = direction.magnitude;

        if (isShiftPressed && direction.magnitude > 0)
        {
            isRunning = true;
        }
        else
        {
            isRunning = false;
        }

    }

    public void Run(InputAction.CallbackContext value)
    {
        if (value.performed)
        {
            isShiftPressed = true;
            if (direction.magnitude > 0)
            {
                isRunning = true;
            }
        }

        if (value.canceled)
        {
            isShiftPressed = false;
            isRunning = false;
        }
    }


}
