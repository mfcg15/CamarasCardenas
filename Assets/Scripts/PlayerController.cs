using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    float rotacion = 35f;
    private Animator anim;
    float x, y;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Translate(0,0, y* Time.deltaTime * speed);
        transform.Rotate(0, x * Time.deltaTime * rotacion,0);

        anim.SetFloat("SpeedX", x);
        anim.SetFloat("SpeedY", y);
    }
}
