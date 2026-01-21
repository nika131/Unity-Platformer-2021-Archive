using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrowtrap : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] fireball;
    private float cooldownTimer;

    private void Attack()
    {
        cooldownTimer = 0;

        fireball[FindFireball()].transform.position = firePoint.position;
        fireball[FindFireball()].GetComponent<EnemyProjectaile>().ActivateProjectile();
    }

    private int FindFireball()
    {
        for (int i = 0; i < fireball.Length; i++)
        {
            if (!fireball[i].activeInHierarchy) 
                return i;
        }
        return 0;
    }

    private void Update()
    {
        cooldownTimer += Time.deltaTime;

        if (cooldownTimer >= attackCooldown)
            Attack();
    }

}
