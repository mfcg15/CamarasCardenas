using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasController : MonoBehaviour
{
    public GameObject[] cameras;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1))
        {
            cameras[0].SetActive(true);
            cameras[1].SetActive(false);
            cameras[2].SetActive(false);
            cameras[3].SetActive(false);
            cameras[4].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(true);
            cameras[2].SetActive(false);
            cameras[3].SetActive(false);
            cameras[4].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(false);
            cameras[2].SetActive(true);
            cameras[3].SetActive(false);
            cameras[4].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F4))
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(false);
            cameras[2].SetActive(false);
            cameras[3].SetActive(true);
            cameras[4].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F5))
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(false);
            cameras[2].SetActive(false);
            cameras[3].SetActive(false);
            cameras[4].SetActive(true);
        }
    }
}
