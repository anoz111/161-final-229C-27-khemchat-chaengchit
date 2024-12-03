using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName;

    public void InitString(string Circle, string Square)
    {
        shapeName = Circle;
        shapeName = Square;
        Debug.Log($"Shape name is : {shapeName}");
    }
    public abstract void CalculateArea();
    public void Resize()
    {
        Debug.Log($"{shapeName} got resize");
    }
    public void Draw()
    {
        Debug.Log($"Let's Drawing {shapeName}");
    }


}