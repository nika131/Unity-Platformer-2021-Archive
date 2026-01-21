using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    [Header ("health")]
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;

    [Header("iframes")]
    [SerializeField] private float iframesDuration;
    [SerializeField] private int numberOfflashes;
    private SpriteRenderer spriteRend;

    private bool invulnerable;

    [SerializeField] private AudioSource hurtSoundEffect;
    [SerializeField] private AudioSource dieSoundEffect;
    [SerializeField] private AudioSource collectSoundEffect;

    public GameObject GameOverUI;

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        spriteRend = GetComponent<SpriteRenderer>();
        invulnerable = false;
        Physics2D.IgnoreLayerCollision(6, 7, false);
         
    }

    public void TakeDamage(float _damage)
    {
        if (invulnerable) return;
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            anim.SetTrigger("hurt");
            StartCoroutine(Invunerability());
            hurtSoundEffect.Play();
        }
        
        else
        {
            if (!dead)
            {
                anim.SetTrigger("die");
                GetComponent<PlayerController>().enabled = false;
                dead = true;
                dieSoundEffect.Play();
                
            }  
           
        }

    }

    public void Addhealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
        collectSoundEffect.Play();
    }

    private IEnumerator Invunerability()
    {
        invulnerable = true;
        Physics2D.IgnoreLayerCollision(6, 7, true);
        for (int i = 0; i < numberOfflashes; i++)
        {
            spriteRend.color = new Color(1, 0, 0, 0.5f);
            yield return new WaitForSeconds(0.5f);
            spriteRend.color = Color.white;
            yield return new WaitForSeconds(0.5f);
        }
        Physics2D.IgnoreLayerCollision(6, 7, false);
        invulnerable = false;
    }

    public void RestartLevel()
    {
        if(dead == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
