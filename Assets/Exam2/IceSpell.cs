using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    public override void Cast()
    {
        Debug.Log($"Casting a Ice Sword Hit them all!");
    }

    void Start()
    {
        Cast();
    }
}
