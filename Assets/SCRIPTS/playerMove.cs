using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMove : MonoBehaviour
{
    Rigidbody2D rb;

    PlayerInput input;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        input= GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 controlNuevo = input.actions["Movimiento"].ReadValue<Vector2>()*10;
        Debug.Log(controlNuevo);

        rb.velocity = controlNuevo;
        /*
        float posX = Input.GetAxis("Horizontal")*10;
        float posY = Input.GetAxis("Vertical")*10;

        rb.velocity = new Vector2(posX, posY);
        */
    }
}
