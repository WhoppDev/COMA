using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientController : MonoBehaviour
{
    [SerializeField] private EnemyStatus enemyStatus;
    [SerializeField] private Animator anim;
    [SerializeField] private ParticleSystem bloodParticle;

    [SerializeField] private Collider2D enemyView;
    [SerializeField] private bool viewPlayer = false;
    [SerializeField] private Collider2D enemyAttack;

    [SerializeField] private Transform[] walkPoints;
    public int currentPointIndex = 0;


    [SerializeField] private float currentEnemyLife;
    public float attackRange;

    private void Start()
    {
        currentEnemyLife = enemyStatus.maxEnemyLife;
    }

    private void Update()
    {
        AttackPatient();
        WalkPatient();

    }

    private void WalkPatient()
    {
        if (viewPlayer)
        {
            anim.SetBool("isWalk", false);
            return;
        }

        if (Vector3.Distance(transform.position, walkPoints[currentPointIndex].position) < 0.1f)
        {
            currentPointIndex = (currentPointIndex + 1) % walkPoints.Length;
        }

        Vector3 directionToNextPoint = walkPoints[currentPointIndex].position - transform.position;
        transform.position = Vector3.MoveTowards(transform.position, walkPoints[currentPointIndex].position, enemyStatus.enemySpeed * Time.deltaTime);

        if (directionToNextPoint.x > 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (directionToNextPoint.x < 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

        anim.SetBool("isWalk", directionToNextPoint.magnitude > 0.01);
    }


    private void AttackPatient()
    {
        if (currentEnemyLife <= 0)
        {
            Destroy(gameObject);
        }

        float distanceToPlayer = Vector3.Distance(CORE.instance.player.transform.position, this.transform.position);
        if (distanceToPlayer < attackRange)
        {
            viewPlayer = true;
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
