using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
    }

    public void Overview()
    {
        gameObject.SetActive(true);
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
    }

    public void Inheritance()
    {
        gameObject.SetActive(false);
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
    }

    public void Abstraction()
    {
        gameObject.SetActive(false);
        cam1.SetActive(false);
        cam2.SetActive(true);
        cam3.SetActive(false);
        cam4.SetActive(false);
    }

    public void Polymorphism()
    {
        gameObject.SetActive(false);
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(true);
        cam4.SetActive(false);
    }

    public void Encapsulation()
    {
        gameObject.SetActive(false);
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(true);
    }

    public void ResetCamera()
    {
        gameObject.SetActive(true);
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
    }
}
