using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CombatController : MonoBehaviour
{
    [SerializeField] private Animator anim;
    public bool isAttacking = false;

    public void Attack(InputAction.CallbackContext value)
    {
        if (value.performed && !isAttacking)
        {
            anim.SetTrigger("isAttackOne");
            isAttacking = true;
        }
        else if (value.performed && isAttacking)
        {
            anim.SetTrigger("isAttackTwo");
        }
    }

    public void ResetAttack()
    {
        isAttacking = false;
    }
}
