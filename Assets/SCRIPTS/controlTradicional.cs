using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class controlTradicional : MonoBehaviour
{
    Rigidbody2D rb;
    public float playerSpeed;
    PlayerInput misInputs;
    [SerializeField] PlayableDirector cut1;
    Transform laMira;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        misInputs = GetComponent<PlayerInput>();
        laMira= GameObject.Find("Mira").GetComponent<Transform>();
    }
    public GameObject bala;
    void Update()
    {
        Vector2 movimiento = misInputs.actions["Movimiento"].ReadValue<Vector2>();
        rb.velocity = movimiento*playerSpeed;

        if (misInputs.actions["Disparo"].WasPressedThisFrame())
        {
            Instantiate(bala, laMira.position, laMira.rotation);
        }
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("cutscene1"))
        {
            cut1.Play();
        }
    }

}
