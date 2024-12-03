using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class EarthSpell : Spell
{
    public override void Cast()
    {
        Debug.Log($"Casting a EarthPower Hit them all!");
    }

    public void newTypeOfCast() 
    {
        Debug.Log("Casting a Stone Attack Them!");
    }
    void Start()
    {
        Cast();
        newTypeOfCast();
    }
}
