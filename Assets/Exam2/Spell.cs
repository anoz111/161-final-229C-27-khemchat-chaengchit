using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public virtual void Cast() 
    {
        Debug.Log("Casting a generuc spell!");
    }

    public void Cast(string cast) 
    {
        Debug.Log($"Casting a spell on target Slime");
    }
    public void Cast(string enemy, int level) 
    {
        enemy = "Dragon";
        level = 10;
    }


}
