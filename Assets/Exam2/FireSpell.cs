using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    public override void Cast()
    {
        Debug.Log($"Casting a Fireball Hit them all!");
    }

    void Start()
    {
        Cast();
    }
}
