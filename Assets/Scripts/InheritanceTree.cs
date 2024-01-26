using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritanceTree : BaseTree // INHERITANCE
{
    public ParticleSystem darkGreenLeaf;
    public GameObject inheritanceDead;
    public GameObject inheritanceAlive;

    public override void MakeSoundAndParticles() // POLYMORPHISM
    {
        base.MakeSoundAndParticles();
        Abstraction();
    }

    public void Abstraction() // ABSTRACTION
    {
        darkGreenLeaf.Play();
        
        var mainModule = darkGreenLeaf.main;
        mainModule.startColor = LeafColor; // ENCAPSULATION
    }

    public override void Die() // POLYMORPHISM
    {
        if (currentHealth <= 0)
        {
            inheritanceAlive.SetActive(false);
            inheritanceDead.SetActive(true);
        }
    }

    public override void Revive() // POLYMORPHISM
    {
        base.Revive();
        inheritanceAlive.SetActive(true);
        inheritanceDead.SetActive(false);
    }
}