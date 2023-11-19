using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientController : MonoBehaviour
{
    [SerializeField] private EnemyStatus enemyStatus;
    [SerializeField] private Animator anim;
    [SerializeField] private ParticleSystem bloodParticle;

    [SerializeField] private Collider2D enemyView;
    [SerializeField] private Collider2D enemyAttack;


    [SerializeField] private float currentEnemyLife;
    public float attackRange;

    private void Start()
    {
        currentEnemyLife = enemyStatus.maxEnemyLife;
    }

    private void Update()
    {
        if(currentEnemyLife <= 0)
        {
            Destroy(gameObject);
        }

        float distanceToPlayer = Vector3.Distance(CORE.instance.player.transform.position, this.transform.position);
        if(distanceToPlayer < attackRange) 
        {
            anim.SetTrigger("Attack");
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("AttackPlayer"))
        {
            currentEnemyLife--;
            bloodParticle.Play();
            Debug.Log(currentEnemyLife);
        }



    }
}
