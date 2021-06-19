using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalDog : Animals
{
   
    public override void SetLifePoints()
    {
        lifePoints = 150;
    }
    public override void InflictDamage()
    {
        playerStats.lifePoints -= 5;
    }
    public override void TakeDamage()
    {
        lifePoints -= 100;
    }
   
}
