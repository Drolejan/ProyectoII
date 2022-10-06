using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipControls : MonoBehaviour
{
    public bool aiming;
    public float dir;
    public bool powerBar;
    public float force;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")&&aiming==false)
        {
            if (powerBar == true)
            {
                rb.AddForce(Vector3.up * force);
                aiming = false;
                powerBar = false;
            }
            else
            {
                aiming = true;
            }
        }
        else if(Input.GetButtonDown("Fire1") && aiming == true)
        {
            aiming=false;
            powerBar = true;
        }
        if (aiming)
        {
            dir++;
            if (dir > 360)
            {
                dir = 0;
            }
        }
        if (powerBar)
        {
            force+=10;
            if (force > 1000)
            {
                force = 0;
            }
        }

    }
}
