using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoviment : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator anim;
    [SerializeField] private float playerSpeed = 5f;
    private Vector2 direction;

    private void Update()
    {
        WalkAnimation();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(direction.x * playerSpeed, rb.velocity.y);

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

    }
}
