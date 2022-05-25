using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coords
{ 
    public float getCoordX(GameObject square)
    {
        return square.transform.position.x;
    }

    public float getCoordY(GameObject square)
    {
        return square.transform.position.y;
    }

    public void setCoords(GameObject square, InputField inputX, InputField inputY, double x, double y)
    {
        square.transform.position = new Vector2((float)x, (float)y);
        inputX.text = x.ToString();
        inputY.text = y.ToString();
    }
}
