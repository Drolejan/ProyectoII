using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBalita : MonoBehaviour
{
    Transform firePoint;
    public float bulletForce;
    Rigidbody2D rb;
    void Start()
    {
        firePoint=GameObject.Find("Mira").GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
