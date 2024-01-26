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
    public int currentHealth;
    public GameObject healthBar;
    public TMP_Text cHealth;
    public int damageAmount;

    [SerializeField]
    private Color leafColor;
    public Color LeafColor
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
            cHealth.SetText("Click!");
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

    public void SetHealth(int health)
    {
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
    }

    public virtual void Die()
    {
       // Code in child classes
    }

    public virtual void Revive()
    {
        currentHealth = maxHealth;
    }
}
