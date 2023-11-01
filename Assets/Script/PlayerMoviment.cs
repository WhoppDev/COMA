using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoviment : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float playerSpeed = 5f;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        
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

        public void Moviment(InputAction.CallbackContext value)
    {
        direction = value.ReadValue<Vector2>();
    }
}
