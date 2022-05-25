using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reflection : MonoBehaviour
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

    public void AxisX()
    {
        x = coords.getCoordX(square);
        y = coords.getCoordY(square);
        newX = (1 * x) + (0 * y);
        newY = (0 * x) + (-1 * y);
        coords.setCoords(square, inputX, inputY, newX, newY);
    }

    public void AxisY()
    {
        x = coords.getCoordX(square);
        y = coords.getCoordY(square);
        newX = (-1 * x) + (0 * y);
        newY = (0 * x) + (1 * y);
        coords.setCoords(square, inputX, inputY, newX, newY);
    }

    public void Origin()
    {
        x = coords.getCoordX(square);
        y = coords.getCoordY(square);
        newX = (-1 * x) + (0 * y);
        newY = (0 * x) + (-1 * y);
        coords.setCoords(square, inputX, inputY, newX, newY);
    }

    public void YequalX()
    {
        x = coords.getCoordX(square);
        y = coords.getCoordY(square);
        newX = (0 * x) + (1 * y);
        newY = (1 * x) + (0 * y);
        coords.setCoords(square, inputX, inputY, newX, newY);
    }

    public void YequalMinusX()
    {
        x = coords.getCoordX(square);
        y = coords.getCoordY(square);
        newX = (0 * x) + (-1 * y);
        newY = (-1 * x) + (0 * y);
        coords.setCoords(square, inputX, inputY, newX, newY);
    }

    public void Define()
    {
        newX = double.Parse(inputX.text);
        newY = double.Parse(inputY.text);
        coords.setCoords(square, inputX, inputY, newX, newY);
    }
}
