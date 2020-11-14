using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float sens;//"чувствительность" мыши
    private Vector3 mousePos;
    private float Angle = 0F;
    public float speed; //скорость перемещения

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))//если мышь зажата
        {
            Angle = 0;
            Angle = sens * ((mousePos.x - (Screen.width / 2)) / Screen.width); // чем дальше от центра курсор, тем быстрее происходит поворот

            transform.RotateAround(transform.position, transform.up, Angle);
        }
        float moveHor = Input.GetAxis("Horizontal");
        float moveVer = Input.GetAxis("Vertical");

        Vector3 new_vector_movement = new Vector3(moveHor, 0.0f, moveVer);

        transform.Translate(new_vector_movement * speed);
    }

    void Update()
    {
        mousePos = Input.mousePosition;
    }
}
