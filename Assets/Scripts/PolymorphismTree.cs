using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolymorphismTree : BaseTree // INHERITANCE
{
    public ParticleSystem tropicalGreenLeaf;
    public GameObject polymorphismDead;
    public GameObject polymorphismAlive;

    public override void MakeSoundAndParticles() // POLYMORPHISM
    {
        base.MakeSoundAndParticles();
        Abstraction();
    }

    public void Abstraction() // ABSTRACTION
    {
        tropicalGreenLeaf.Play();
        
        var mainModule = tropicalGreenLeaf.main;
        mainModule.startColor = LeafColor; // ENCAPSULATION
    }

    public override void Die() // POLYMORPHISM
    {
        if (currentHealth <= 0)
        {
            polymorphismAlive.SetActive(false);
            polymorphismDead.SetActive(true);
        }
    }

    public override void Revive() // POLYMORPHISM
    {
        base.Revive();
        polymorphismAlive.SetActive(true);
        polymorphismDead.SetActive(false);
    }
}
