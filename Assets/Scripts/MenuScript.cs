using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickDemo()
    {
        SceneManager.LoadScene("Demo");
    }

    public void OnClickReflection()
    {

        SceneManager.LoadScene("Reflection");
    }

    public void OnClickDilationContraction()
    {

        SceneManager.LoadScene("DilationContraction");
    }

    public void OnClickRotation()
    {
        SceneManager.LoadScene("Rotation");
    }

    public void OnClickShear()
    {
        SceneManager.LoadScene("Shear");
    }

    public void OnClickBack()
    {
        SceneManager.LoadScene("Menu");
    }
}
