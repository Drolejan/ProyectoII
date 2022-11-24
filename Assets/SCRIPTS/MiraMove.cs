using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiraMove : MonoBehaviour
{
    Vector2 mousePos;
    Rigidbody2D rb;
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }

    private void FixedUpdate()
    {
        //rb.MovePosition(rb.position + movimiento * velocidad * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angulo = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angulo;
    }
}
