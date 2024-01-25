using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BaseTree : MonoBehaviour
{
    string targetTag = "Tree";

    public AudioClip wav_Tree;
    public int maxHealth = 25;
    private int currentHealth;
    public GameObject healthBar;
    public Slider healthSlider;
    public TMP_Text cHealth;
    public int damageAmount;

    public ParticleSystem leafParticles;
    public Color leafColor
    {
        get 
        {
            return leafColor;
        }
        set 
        {
            leafColor = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        SetMaxHealth(maxHealth);
    }

    public void OnMouseEnter()
    {
        if (CompareTag(targetTag))
        {
            healthBar.SetActive(true);
        }
        if (!CompareTag(targetTag))
        {
            healthBar.SetActive(false);
        }
    }

    public void OnMouseExit()
    {
        if (CompareTag(targetTag))
        {
            healthBar.SetActive(false);
        }
    }

    public virtual void OnMouseDown()
    {
        if (CompareTag(targetTag))
        {
            MakeSoundAndParticles();
            TakeDamage(damageAmount);

            if (currentHealth <= 0)
            {
                Die();
            }
        }
    }

    public void SetMaxHealth(int health)
    {
        healthSlider.maxValue = health;
        healthSlider.value = health;
    }

    public void SetHealth(int health)
    {
        healthSlider.value = health;
        cHealth.SetText(currentHealth.ToString());
    }

    public virtual void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        SetHealth(currentHealth);
    }

    public virtual void MakeSoundAndParticles()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = wav_Tree;
        audioSource.Play();
        leafParticles.Play();
    }

    public virtual void Die()
    {
       
    }

    public virtual void Revive()
    {
        currentHealth = maxHealth;
    }
}
