using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    private float radius = 5;
    public override void CalculateArea()
    {
        radius = Mathf.PI * radius * radius;
        Debug.Log($"Circle Area is {radius}");
    }
    public void Start()
    {
        shapeName = "Circle";
        Draw();
        Resize();
        CalculateArea();
    }

}
