using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private float Area = 4;
    public override void CalculateArea()
    {
        Area = Area * Area;
        Debug.Log($"Square side is {Area}");
    }
    private void Start()
    {
        shapeName = "Square";
        Draw();
        Resize();
        CalculateArea();
    }
}
