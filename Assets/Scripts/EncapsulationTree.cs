using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncapsulationTree : BaseTree // INHERITANCE
{
    public ParticleSystem largeGreenLeaf;
    public GameObject encapsulationDead;
    public GameObject encapsulationAlive;

    public override void MakeSoundAndParticles() // POLYMORPHISM
    {
        base.MakeSoundAndParticles();
        Abstraction();
    }

    public void Abstraction() // ABSTRACTION
    {
        largeGreenLeaf.Play();
        
        var mainModule = largeGreenLeaf.main;
        mainModule.startColor = LeafColor; // ENCAPSULATION
    }

    public override void Die() // POLYMORPHISM
    {
        if (currentHealth <= 0)
        {
            encapsulationAlive.SetActive(false);
            encapsulationDead.SetActive(true);
        }
    }

    public override void Revive() // POLYMORPHISM
    {
        base.Revive();
        encapsulationAlive.SetActive(true);
        encapsulationDead.SetActive(false);
    }
}
