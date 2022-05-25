using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    public GameObject square;
    double x, y, newX, newY;
    public InputField inputX, inputY;
    public Slider sliderAngle;
    public Text textAngle;
    int angle;
    Coords coords = new Coords();

    // Start is called before the first frame update
    void Start()
    {
        coords.setCoords(square, inputX, inputY, 1, 1);
    }

    public void OnSlide()
    {
        textAngle.text = sliderAngle.value.ToString();
    }

    public void Rotate()
    {
        x = coords.getCoordX(square);
        y = coords.getCoordY(square);
        angle = int.Parse(textAngle.text);
        double angleConverted = Mathf.PI * angle / 180.0;
        float cos = Mathf.Cos((float)angleConverted);
        float sin = Mathf.Sin((float)angleConverted);
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
