using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractionTree : BaseTree // INHERITANCE
{
    public ParticleSystem lightGreenLeaf;
    public GameObject abstractionDead;
    public GameObject abstractionAlive;

    public override void MakeSoundAndParticles() // POLYMORPHISM
    {
        base.MakeSoundAndParticles();
        Abstraction();
    }

    public void Abstraction() // ABSTRACTION
    {
        lightGreenLeaf.Play();
        
        var mainModule = lightGreenLeaf.main;
        mainModule.startColor = LeafColor; // ENCAPSULATION
    }

    public override void Die() // POLYMORPHISM
    {
        if (currentHealth <= 0)
        {
            abstractionAlive.SetActive(false);
            abstractionDead.SetActive(true);
        }
    }

    public override void Revive() // POLYMORPHISM
    {
        base.Revive();
        abstractionAlive.SetActive(true);
        abstractionDead.SetActive(false);
    }
}
