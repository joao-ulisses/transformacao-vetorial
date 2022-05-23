using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransformationScript : MonoBehaviour
{
    public GameObject square;
    double x, y, newX, newY;
    public Text textX, textY;

    // Start is called before the first frame update
    void Start()
    {
        setCoords(1, 1);
    }

    void getCoords()
    {
        x = square.transform.position.x;
        y = square.transform.position.y;
    }

    void setCoords(double x, double y)
    {
        square.transform.position = new Vector2((float)x, (float)y);
        textX.text = "X: " + x;
        textY.text = "y: " + y;
    }

    public void Reflection()
    {
        getCoords();
        newX = (1*x) + (0*y);
        newY = (0 * x) + (-1 * y);
        setCoords(newX, newY);
    }

    public void Dilation()
    {
        getCoords();
        newX = (2*x) + (0*y);
        newY = (0*x) + (2*y);
        setCoords(newX, newY);
    }

    public void Contraction()
    {
        getCoords();
        newX = (0.5 * x) + (0 * y);
        newY = (0 * x) + (0.5 * y);
        setCoords(newX, newY);
    }

    public void Shear()
    {
        getCoords();
        newX = (1 * x) + (2 * y);
        newY = (0 * x) + (1 * y);
        setCoords(newX, newY);
    }

    public void Rotation()
    {
        getCoords();
        newX = (Mathf.Cos(60) * x) + (-Mathf.Sin(60) * y);
        newY = (Mathf.Sin(60) * x) + (Mathf.Cos(60) * y);
        setCoords(newX, newY);
    }
}
