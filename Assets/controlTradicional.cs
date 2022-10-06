using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class controlTradicional : MonoBehaviour
{
    Rigidbody2D rb;
    public float playerSpeed;
    PlayerInput misInputs;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        misInputs = GetComponent<PlayerInput>();
    }
    public GameObject bala;
    void Update()
    {
        Vector2 movimiento = misInputs.actions["Movimiento"].ReadValue<Vector2>();
        rb.velocity = movimiento*playerSpeed;

        if (misInputs.actions["Disparo"].WasPressedThisFrame())
        {
            Instantiate(bala, transform.position, Quaternion.identity);
        }
      
    }

}
