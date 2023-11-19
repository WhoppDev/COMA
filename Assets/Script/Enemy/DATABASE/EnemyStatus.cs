using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="EnemyStatus", menuName ="Scriptable/Enemy")]
public class EnemyStatus : ScriptableObject
{
    public string enemyName;
    public float maxEnemyLife;
    public float enemyKnockback;
    public float enemyDamage;
    public float enemySpeed;

}
