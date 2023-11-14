using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientController : MonoBehaviour
{
    [SerializeField] private EnemyStatus enemyStatus;
    [SerializeField] private ParticleSystem bloodParticle;


    [SerializeField] private float currentEnemyLife;

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
