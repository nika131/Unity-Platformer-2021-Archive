using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerAttack : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public Transform attackPos;
    public LayerMask whatIsEnemies;
   
    public Animator playerAnim;
    public float attackRange;
    public int damage;

    [SerializeField] private AudioSource attackSoundEffect;

    void Update()
    {
        if (timeBtwAttack <= 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                attackSoundEffect.Play();
                playerAnim.SetTrigger("attack");
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    EnemyPatrol enemyScript = enemiesToDamage[i].GetComponent<EnemyPatrol>();

                    if (enemyScript != null)
                    {
                        enemyScript.TakeDmage(damage);
                    }
                }
            }
            timeBtwAttack = startTimeBtwAttack;
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }



        
        
            if (CrossPlatformInputManager.GetButtonDown("Bang"))
            {
                attackSoundEffect.Play();
                playerAnim.SetTrigger("attack");
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    EnemyPatrol enemyScript = enemiesToDamage[i].GetComponent<EnemyPatrol>();

                    if (enemyScript != null)
                    {
                        enemyScript.TakeDmage(damage);
                    }
                }
            timeBtwAttack = startTimeBtwAttack;
            }
            else
            { 
                timeBtwAttack -= Time.deltaTime;
            }
    }
        
    

           
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
