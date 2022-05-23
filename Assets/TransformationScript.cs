using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransformationScript : MonoBehaviour
{
    public GameObject square;
    double x, y, newX, newY;
    public Text textX, textY;
    public InputField inputX, inputY;

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
        inputX.text = x.ToString();
        inputY.text = y.ToString();
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
        double angle = Mathf.PI * 60 / 180.0;
        float cos = Mathf.Cos((float)angle);
        float sin = Mathf.Sin((float)angle);
        newX = (cos * x) + (-sin * y);
        newY = (cos * x) + (sin * y);
        setCoords(newX, newY);
    }

    public void Define()
    {
        newX = double.Parse(inputX.text);
        newY = double.Parse(inputY.text);
        setCoords(newX, newY);
    }
}
