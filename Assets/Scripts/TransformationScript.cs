using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransformationScript : MonoBehaviour
{
    public GameObject square;
    double x, y, newX, newY;
    public InputField inputX, inputY;
    Coords coords = new Coords();

    // Start is called before the first frame update
    void Start()
    {
        coords.setCoords(square, inputX, inputY, 1, 1);
    }

    public void Reflection()
    {
        x = coords.getCoordX(square);
        y = coords.getCoordY(square);
        newX = (1*x) + (0*y);
        newY = (0 * x) + (-1 * y);
        coords.setCoords(square, inputX, inputY, newX, newY);
    }

    public void Dilation()
    {
        x = coords.getCoordX(square);
        y = coords.getCoordY(square);
        newX = (2*x) + (0*y);
        newY = (0*x) + (2*y);
        coords.setCoords(square, inputX, inputY, newX, newY);
    }

    public void Contraction()
    {
        x = coords.getCoordX(square);
        y = coords.getCoordY(square);
        newX = (0.5 * x) + (0 * y);
        newY = (0 * x) + (0.5 * y);
        coords.setCoords(square, inputX, inputY, newX, newY);
    }

    public void Shear()
    {
        x = coords.getCoordX(square);
        y = coords.getCoordY(square);
        newX = (1 * x) + (2 * y);
        newY = (0 * x) + (1 * y);
        coords.setCoords(square, inputX, inputY, newX, newY);
    }

    public void Rotation()
    {
        x = coords.getCoordX(square);
        y = coords.getCoordY(square);
        double angle = Mathf.PI * 60 / 180.0;
        float cos = Mathf.Cos((float)angle);
        float sin = Mathf.Sin((float)angle);
        newX = (cos * x) + (-sin * y);
        newY = (cos * x) + (sin * y);
        coords.setCoords(square, inputX, inputY, newX, newY);
    }

    public void Define()
    {
        newX = double.Parse(inputX.text);
        newY = double.Parse(inputY.text);
        coords.setCoords(square, inputX, inputY, newX, newY);
    }
}
